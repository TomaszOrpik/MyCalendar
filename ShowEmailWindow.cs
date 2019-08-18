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
    public partial class ShowEmailWindow : Form
    {
        public ShowEmailWindow()
        {
            InitializeComponent();
        }

        public string path { get; set; }

        string sended = "Mail not Sended!";

        public string Sended
        {
            get
            {
                return this.Sendedlabel.Text;
            }
            set
            {
                this.Sendedlabel.Text = value;
            }
        }
        public string Date
        {
            get
            {
                return this.Datelabel.Text;
            }
            set
            {
                this.Datelabel.Text = value;
            }
        }
        public string Email
        {
            get
            {
                return this.MyMaillabel.Text;
            }
            set
            {
                this.MyMaillabel.Text = value;
            }
        }
        public string Receiver
        {
            get
            {
                return this.Recipientlabel.Text;
            }
            set
            {
                this.Recipientlabel.Text = value;
            }
        }
        public string Subject
        {
            get
            {
                return this.Subjectlabel.Text;
            }
            set
            {
                this.Subjectlabel.Text = value;
            }
        }
        public string Body
        {
            get
            {
                return this.Bodylabel.Text;
            }
            set
            {
                this.Bodylabel.Text = value;
            }
        }

        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void ShowEmailWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ShowEmailWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MailWindowMessageBox Message = new MailWindowMessageBox();
            Message.Text = "Deleted mail won't be send!";
            Message.Show();
            File.Delete(this.path);
            this.Close();
        }
    }
}
