using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class SettingsDefaultEmail : Form
    {
        public SettingsDefaultEmail()
        {
            InitializeComponent();
        }

        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void SettingDefaultEmail_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SettingDefaultEmail_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)+"\\personal.setting", false))
            {
                sw.WriteLine(textBoxMyMail.Text);
                sw.WriteLine(textBoxMyPassword.Text);

                SettingsMessageBox Message = new SettingsMessageBox();
                Message.Text = "Default E-mail & password changed!";
                Message.Show();
                this.Close();
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxShowPassword.CheckState == CheckState.Checked)
            {
                textBoxMyPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxMyPassword.PasswordChar = '*';
            }
        }
    }
}
