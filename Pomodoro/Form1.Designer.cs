namespace Pomodoro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.pomodoroTimer = new System.Windows.Forms.Timer(this.components);
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.txtNewTasks = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblPomodoroProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(148, 116);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(341, 215);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(86, 386);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 86);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(250, 386);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(140, 86);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(414, 386);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 86);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMode
            // 
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(148, 29);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(341, 60);
            this.lblMode.TabIndex = 4;
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMode.Click += new System.EventHandler(this.label1_Click);
            // 
            // pomodoroTimer
            // 
            this.pomodoroTimer.Interval = 1000;
            this.pomodoroTimer.Tick += new System.EventHandler(this.pomodoroTimer_Tick);
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 25;
            this.lstTasks.Location = new System.Drawing.Point(86, 558);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(468, 104);
            this.lstTasks.TabIndex = 5;
            // 
            // txtNewTasks
            // 
            this.txtNewTasks.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewTasks.Location = new System.Drawing.Point(86, 683);
            this.txtNewTasks.Name = "txtNewTasks";
            this.txtNewTasks.Size = new System.Drawing.Size(186, 31);
            this.txtNewTasks.TabIndex = 6;
            this.txtNewTasks.TextChanged += new System.EventHandler(this.txtNewTasks_TextChanged);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(414, 683);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(140, 50);
            this.btnAddTask.TabIndex = 7;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(86, 490);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(468, 42);
            this.progressBar1.TabIndex = 8;
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Location = new System.Drawing.Point(86, 816);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(149, 29);
            this.chkDarkMode.TabIndex = 9;
            this.chkDarkMode.Text = "Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(414, 739);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(140, 50);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(414, 795);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(140, 50);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblPomodoroProgress
            // 
            this.lblPomodoroProgress.AutoSize = true;
            this.lblPomodoroProgress.Location = new System.Drawing.Point(13, 13);
            this.lblPomodoroProgress.Name = "lblPomodoroProgress";
            this.lblPomodoroProgress.Size = new System.Drawing.Size(0, 25);
            this.lblPomodoroProgress.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 909);
            this.Controls.Add(this.lblPomodoroProgress);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.chkDarkMode);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtNewTasks);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Name = "Form1";
            this.Text = "Pomodoro Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Timer pomodoroTimer;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.TextBox txtNewTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblPomodoroProgress;
    }
}

