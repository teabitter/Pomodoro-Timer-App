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

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        private int timeLeft; //in seconds
        private bool isWorkTime = true; //true for work, false for break
        private int pomodoroCount = 0;

        

        public Form1()
        {
            InitializeComponent();
            ResetTimer();
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
                }

                isWorkTime = !isWorkTime;

                if (!isWorkTime)
                {
                    if (pomodoroCount % 4 == 0)
                        timeLeft = 15 * 60; //long break
                    else
                        timeLeft = 5 * 60; //short break
                }
                else
                {
                    timeLeft = 25 * 60;
                }
                lblMode.Text = isWorkTime ? "Work Time" : (pomodoroCount % 4 == 0 ? "Long Break" : "Short Break");
                UpdateTimerLabel();
                pomodoroTimer.Start();

                SystemSounds.Exclamation.Play(); //plays system sound
                //SoundPlayer player = new SoundPlayer(@"C:\path\to\sound.wav");
                //player.Play(); THIS IS FOR A CUSTOM SOUND
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

        private void ApplyDarkTheme()
        {
            // Form background
            this.BackColor = Color.FromArgb(30, 30, 30); // dark gray

            // Labels
            lblTimer.ForeColor = Color.White;
            lblMode.ForeColor = Color.White;

            //List
            lstTasks.BackColor = Color.FromArgb(50, 50, 50);
            lstTasks.ForeColor = Color.White;
            lstTasks.BorderStyle = BorderStyle.FixedSingle;

            // Progress Bar
            progressBar1.ForeColor = Color.White;
            progressBar1.BackColor = Color.Gray;

            // Buttons
            Button[] buttons = { btnStart, btnPause, btnReset, btnAddTask, btnDone, btnRemove };
            foreach (var btn in buttons)
            {
                btn.BackColor = Color.FromArgb(50, 50, 50);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.DarkGray;
            }

            // Checkbox
            chkDarkMode.ForeColor = Color.White;
            chkDarkMode.BackColor = Color.FromArgb(30, 30, 30);

            // Textbox
            txtNewTasks.BackColor = Color.FromArgb(50, 50, 50);
            txtNewTasks.ForeColor = Color.White;
            txtNewTasks.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ApplyLightTheme()
        {
            this.BackColor = Color.White;

            lblTimer.ForeColor = Color.Black;
            lblMode.ForeColor = Color.Black;

            //List
            lstTasks.BackColor = Color.White;
            lstTasks.ForeColor = Color.Black;



            progressBar1.ForeColor = Color.Black;
            progressBar1.BackColor = Color.LightGray;

            Button[] buttons = { btnStart, btnPause, btnReset, btnAddTask, btnDone, btnRemove };
            foreach (var btn in buttons)
            {
                btn.BackColor = Color.WhiteSmoke;
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Standard;
            }

            chkDarkMode.ForeColor = Color.Black;
            chkDarkMode.BackColor = Color.White;

            txtNewTasks.BackColor = Color.White;
            txtNewTasks.ForeColor = Color.Black;
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
                ApplyDarkTheme();
            else
                ApplyLightTheme();
        }

        private void Form1_Close(object sender, EventArgs e)
        {
           
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
