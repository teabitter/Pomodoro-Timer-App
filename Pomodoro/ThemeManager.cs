using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public class ThemeManager
    {
        public static void ApplyDarkTheme(Form form)
        {
            form.BackColor = Color.FromArgb(30, 30, 30);

            foreach (Control control in form.Controls)
            {
                ApplyDarkStyle(control);
            }
        }

        public static void ApplyLightTheme(Form form)
        {
            form.BackColor = SystemColors.Control;

            foreach (Control control in form.Controls)
            {
                ApplyLightStyle(control);
            }
        }

        private static void ApplyDarkStyle(Control control)
        {
            switch (control)
            {
                case Label lbl:
                    lbl.ForeColor = Color.White;
                    break;
                case ListBox listBox:
                    listBox.BackColor = Color.FromArgb(50, 50, 50);
                    listBox.ForeColor = Color.White;
                    break;
                case ProgressBar progressBar:
                    progressBar.BackColor = Color.Gray;
                    break;
                case Button btn:
                    btn.BackColor = Color.FromArgb(50, 50, 50);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.DarkGray;
                    break;
                case TextBox txt:
                    txt.BackColor = Color.FromArgb(50, 50, 50);
                    txt.ForeColor = Color.White;
                    break;
                case CheckBox chk:
                    chk.BackColor = Color.FromArgb(30, 30, 30);
                    chk.ForeColor = Color.White;
                    break;
            }

            foreach (Control child in control.Controls)
            {
                ApplyDarkStyle(child);
            }
        }

        private static void ApplyLightStyle(Control control)
        {
            switch (control)
            {
                case Label lbl:
                    lbl.ForeColor = Color.Black;
                    break;
                case ListBox listBox:
                    listBox.BackColor = SystemColors.Window;
                    listBox.ForeColor = Color.Black;
                    break;
                case ProgressBar progressBar:
                    progressBar.BackColor = SystemColors.ControlLight;
                    break;
                case Button btn:
                    btn.BackColor = SystemColors.Control;
                    btn.ForeColor = Color.Black;
                    btn.FlatStyle = FlatStyle.Standard;
                    break;
                case TextBox txt:
                    txt.BackColor = SystemColors.Window;
                    txt.ForeColor = Color.Black;
                    break;
                case CheckBox chk:
                    chk.BackColor = SystemColors.Control;
                    chk.ForeColor = Color.Black;
                    break;
            }

            foreach (Control child in control.Controls)
            {
                ApplyLightStyle(child);
            }
        }
    }
}


