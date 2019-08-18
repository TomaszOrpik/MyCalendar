using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class SettingsMessageBox : Form
    {
        public SettingsMessageBox()
        {
            InitializeComponent();
        }

        public string Text
        {
            get
            {
                return this.labelText.Text;
            }
            set
            {
                this.labelText.Text = value;
            }
        }

        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void SettingsMessageBox_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SettingsMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
