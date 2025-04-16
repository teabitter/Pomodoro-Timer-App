using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using NAudio.Wave;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        private int timeLeft; //in seconds
        private bool isWorkTime = true; //true for work, false for break
        private int pomodoroCount = 0;
        private int pomodorosCompleted = 0;

        

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_Close);
            ResetTimer();
            LoadTasks();

        }
        private void ResetTimer()
        {
            timeLeft = isWorkTime ? 25 * 60 : 5 * 60;
            UpdateTimerLabel();
            lblMode.Text = isWorkTime ? "Work Time" : "Break Time";
        }

        private void UpdateTimerLabel()
        {
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            lblTimer.Text = $"{minutes:D2} : {seconds:D2}";

            int total = isWorkTime ? 25 * 60 : (pomodoroCount % 4 == 0 ? 15 * 60 : 5 * 60);
            progressBar1.Maximum = total;
            progressBar1.Value = total - timeLeft;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Stop();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Stop();
            ResetTimer();
        }

        private void pomodoroTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateTimerLabel();
            }
            else
            {
                pomodoroTimer.Stop();

                if (isWorkTime)
                {
                    pomodoroCount++;
                    pomodorosCompleted++; // Increment pomodoros only when a work session is completed.
                    UpdatePomodoroProgress(); // Only show a tomato after a work session.
                }

                isWorkTime = !isWorkTime;

                if (!isWorkTime)
                {
                    if (pomodoroCount % 4 == 0)
                        timeLeft = 15 * 60; // long break
                    else
                        timeLeft = 5 * 60; // short break
                }
                else
                {
                    timeLeft = 25 * 60; // reset to 25 minutes for next work session
                }

                lblMode.Text = isWorkTime ? "Work Time" : (pomodoroCount % 4 == 0 ? "Long Break" : "Short Break");
                UpdateTimerLabel();
                pomodoroTimer.Start();

                SoundPlayer player = new SoundPlayer(@"C:\users\dambn\Downloads\bell-172780.wav");
                player.Play();
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewTasks.Text))
            {
                lstTasks.Items.Add(txtNewTasks.Text);
                txtNewTasks.Clear();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                string selectedTask = lstTasks.SelectedItem.ToString();
                if (!selectedTask.StartsWith("✓"))
                {
                    lstTasks.Items[lstTasks.SelectedIndex] = "✓ " + selectedTask;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
            }
        }
        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
                ThemeManager.ApplyDarkTheme(this);
            else
                ThemeManager.ApplyLightTheme(this);
        }

        private void LoadTasks()
        {
            if (File.Exists("tasks.json"))
            {
                string json = File.ReadAllText("tasks.json");
                List<TaskItem> tasks = JsonConvert.DeserializeObject<List<TaskItem>>(json);

                lstTasks.Items.Clear();
                foreach (var task in tasks)
                {
                    string displayText = task.IsCompleted ? $"✓ {task.Description}" : task.Description;
                    lstTasks.Items.Add(displayText);
                }
            }
        }

        private void UpdatePomodoroProgress()
        {
            lblPomodoroProgress.Text = string.Concat(Enumerable.Repeat("🍅", pomodorosCompleted));
        }

        private void Form1_Close(object sender, EventArgs e)
        {
            List<TaskItem> tasks = new List<TaskItem>();
            foreach (var item in lstTasks.Items)
            {
                string taskText = item.ToString();
                bool isCompleted = taskText.StartsWith("✓");
                string description = isCompleted ? taskText.Substring(2) : taskText;

                tasks.Add(new TaskItem
                {
                    Description = description,
                    IsCompleted = isCompleted
                });
            }
            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText("tasks.json", json);
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void txtNewTasks_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
