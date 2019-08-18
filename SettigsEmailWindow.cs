using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class SettigsEmailWindow : Form
    {
        public SettigsEmailWindow()
        {
            InitializeComponent();
            LoadLink();
        }

        public void LoadLink()
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://developers.google.com/adwords/api/docs/guides/authentication/";
            linkLabel1.Links.Add(link);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxClientID.Text) || string.IsNullOrWhiteSpace(textBoxSecret.Text) || string.IsNullOrWhiteSpace(textBoxProjectID.Text) || string.IsNullOrWhiteSpace(textBoxMail.Text) )
            {

                SettingsMessageBox Message = new SettingsMessageBox();
                Message.Text = "Fill all informations!";
                Message.Show();

            }
            else
            {
                using (var id = new StreamWriter(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\myID.setting", false))
                {
                    id.WriteLine(textBoxClientID.Text);
                    id.WriteLine(textBoxSecret.Text);
                    id.WriteLine(textBoxProjectID.Text);
                    id.WriteLine(textBoxMail.Text);
                    id.Close();

                    SettingsMessageBox Message = new SettingsMessageBox();
                    Message.Text = "Configuration saved!";
                    Message.Show();
                    this.Close();
                }
            }
        }

        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void SettingEmailWindow_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SettingEmailWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        bool idclick = false;
        bool clientclick = false;
        bool secretclick = false;
        bool mailclick = false;

        private void textBoxProjectID_MouseClick(object sender, MouseEventArgs e)
        {
            if(!idclick)
            {
                textBoxClientID.Text = "";
                idclick = true;
            }
        }

        private void textBoxClientID_MouseClick(object sender, MouseEventArgs e)
        {
            if(!clientclick)
            {
                textBoxClientID.Text = "";
                clientclick = true;
            }
        }

        private void textBoxSecret_MouseClick(object sender, MouseEventArgs e)
        {
            if(!secretclick)
            {
                textBoxSecret.Text = "";
                secretclick = true;
            }
        }

        private void textBoxMail_MouseClick(object sender, MouseEventArgs e)
        {
            if(!mailclick)
            {
                textBoxMail.Text = "";
                mailclick = true;
            }
        }
    }
}
