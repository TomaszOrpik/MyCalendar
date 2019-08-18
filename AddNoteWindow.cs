using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyCalendar
{
    public partial class AddNoteWindow : Form
    {
        public AddNoteWindow()
        {
            /// FIRST SCRIPT SELECT MONTH, THAN GENERATE NUMBER OF DAYS, THAN SELECT TODAY
            InitializeComponent();
            GenerateMonth();
            GenerateDays();
            GenerateTodayDay();
        }


        public static TextBox tb = new TextBox();

        NoteWindowMessageBox Message = new NoteWindowMessageBox();

        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void AddNoteWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddNoteWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            /// CHECK LINES BEFORE SAVE
            if (string.IsNullOrWhiteSpace(yearBox.Text) || string.IsNullOrWhiteSpace(MonthBox.Text) || string.IsNullOrWhiteSpace(DayBox.Text) || string.IsNullOrWhiteSpace(MinBox.Text) || string.IsNullOrWhiteSpace(HourBox.Text) || string.IsNullOrWhiteSpace(TitleBox.Text) || string.IsNullOrWhiteSpace(DescriptionBox.Text))
            {
                Message.Text = "Please set all information in Window!"; /// CHANGE REMINDER FOR CUSTOM
                Message.Show();
            }
            else
            {
                TextWriter Save = new StreamWriter(yearBox.Text + MonthBox.Text + DayBox.Text + HourBox.Text + MinBox.Text + ".mnote");
                Save.WriteLine("N");
                Save.WriteLine(yearBox.Text);
                Save.WriteLine(MonthBox.Text);
                Save.WriteLine(DayBox.Text);
                Save.WriteLine(HourBox.Text + ":" + MinBox.Text);
                Save.WriteLine(TitleBox.Text);
                ///CHECKING REMINDER
                if (ReminderBox.CheckState == CheckState.Checked)
                    Save.WriteLine("1");
                else
                    Save.WriteLine("0");

                ///ADDING DESCRIPTION WITH MULTILINES
                for (int i = 0; i < DescriptionBox.Lines.Length; i++)
                {
                    Save.WriteLine(DescriptionBox.Lines[i]);
                }

                Save.Close();
                /// CLOSE WINDOW AFTER SAVE
                this.Close();
            }
        }

        public void AddingNote()
        {
            string year = yearBox.Text;
            string month = MonthBox.Text;
        }

        private void MonthBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateDays();
        }
        ///SELECTING TODAY DATE (YEAR AND MONTH)
        public void GenerateMonth()
        {
            DateTime TodayDate1 = DateTime.Now;

            int NowMonth = TodayDate1.Month;
            MonthBox.SelectedIndex = NowMonth - 1;

            int NowYear = TodayDate1.Year;
            yearBox.Text = Convert.ToString(NowYear);



        }

        public void GenerateTodayDay()
        {
            /// SELECT TODAY + CURRENT TIME
            DateTime TodayDate1 = DateTime.Now;

            int NowDay = TodayDate1.Day;
            DayBox.SelectedIndex = NowDay - 1;

            int NowHour = TodayDate1.Hour;
            HourBox.SelectedIndex = NowHour;

            int NowMinutes = TodayDate1.Minute;
            MinBox.SelectedIndex = NowMinutes;
        }

        public void GenerateDays()
        {
            /// GENERATE NUMBER OF DAYS FOR TODAY + HOURS + MINS
            string year = yearBox.Text;
            int y = 0;
            Int32.TryParse(year, out y);
            string month = MonthBox.Text;

            Dictionary<string, int> Months = new Dictionary<string, int>();

            Months.Add("January", 1);
            Months.Add("February", 2);
            Months.Add("March", 3);
            Months.Add("April", 4);
            Months.Add("May", 5);
            Months.Add("June", 6);
            Months.Add("July", 7);
            Months.Add("August", 8);
            Months.Add("September", 9);
            Months.Add("October", 10);
            Months.Add("November", 11);
            Months.Add("December", 12);

            int M = Months[month];

            int days = DateTime.DaysInMonth(y, M);

            int day = 1;

            DayBox.Items.Clear();

            for (int x = 0; x < days; x++)
            {
                DayBox.Items.Add(Convert.ToString(day));
                day++;
            }
            /// Key = i.ToString("D2");
            int hour = 0;

            HourBox.Items.Clear();

            for (int x = 0; x < 24; x++)
            {
                HourBox.Items.Add(hour.ToString("D2"));
                hour++;
            }

            int minut = 0;

            MinBox.Items.Clear();

            for (int x = 0; x < 60; x++)
            {
                MinBox.Items.Add(minut.ToString("D2"));
                minut++;
            }



        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            /// CLOSE WINDOW
            this.Close();
        }

        private void yearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                /// LIMIT TEXT BOX TO 4 NUMBERS
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                yearBox.MaxLength = 4;
            }
        }

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateDays();
        }
    }
}
