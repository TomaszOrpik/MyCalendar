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
    public partial class ShowNoteWindow : Form
    {
        public ShowNoteWindow()
        {
            InitializeComponent();
        }

        public string noteDate
        {
            get
            {
                return this.labelDate.Text;
            }
            set
            {
                this.labelDate.Text = value;
            }
        }

        public string noteName
        {
            get
            {
                return this.labelNoteName.Text;
            }
            set
            {
                this.labelNoteName.Text = value;
            }
        }

        public string noteDescription
        {
            get
            {
                return this.DescriptionBox.Text;
            }
            set
            {
                this.DescriptionBox.Text = value;
            }
        }

        public string noteReminder
        {
            get
            {
                return this.labelReminder.Text;
            }
            set
            {
                this.labelReminder.Text = value;
            }
        }

        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void ShowNoteWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ShowNoteWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string path { get; set; }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            NoteWindowMessageBox Message = new NoteWindowMessageBox();
            File.Delete(this.path);
            Message.Text = "Note deleted!";
            Message.Show();
            this.Close();

        }
    }
}
