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
    public partial class SettingsColorWindow : Form
    {
        public SettingsColorWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\color.setting", false))
            {
                sw.WriteLine(BackgroundBox.Text+"          ");
                sw.WriteLine(DaysBox.Text + "          ");
                sw.WriteLine(BusyBox.Text + "          ");
                sw.WriteLine(TodayBox.Text + "          ");

                SettingsMessageBox Message = new SettingsMessageBox();
                Message.Text = "Default colors changed!";
                Message.Show();
                this.Close();
            }
        }

        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void SettingsColorWindow_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SettingsColorWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
