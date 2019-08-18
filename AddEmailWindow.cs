using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class AddEmailWindow : Form
    {
        public AddEmailWindow()
        {
            InitializeComponent();
            GenerateMonth();
            GenerateDays();
            GenerateTodayDay();
            SetDefaultEmail();
        }

        public void SetDefaultEmail()
        {
            string personal = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\personal.setting";

            bool exists = System.IO.Directory.Exists(personal);

            if (exists)
            {
                TextReader Load = new StreamReader(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\personal.setting");
                string Mail = "";
                string Password = "";

                Mail = Load.ReadLine();
                Password = Load.ReadLine();
                Load.Close();


                textBoxMyMail.Text = Mail;
                textBoxMyPassword.Text = Password;
            }

        }

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
        /// RECEIVE DATA FROM SETTINGS
        /// add script that will read txt file with password and mail created in settings

        private void SendButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxMyMail.Text) || string.IsNullOrWhiteSpace(textBoxMyPassword.Text) || string.IsNullOrWhiteSpace(textBoxRecipent.Text) || string.IsNullOrWhiteSpace(textBoxSubject.Text) || string.IsNullOrWhiteSpace(textBoxBody.Text))
            {
                MailWindowMessageBox Message = new MailWindowMessageBox();
                Message.Text = "Please set all information in Window!";
                Message.Show();
                this.Close();
            }
            else
            {

                if (checkBoxNow.CheckState == CheckState.Checked)
                {
                    /// SEND MAIL NOW
                    var message = new MailMessage(textBoxMyMail.Text, textBoxRecipent.Text); /// email, recipent
                    message.Subject = textBoxSubject.Text; /// email subject
                    message.Body = textBoxBody.Text; /// email body

                    using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587)) /// loging to SMTP client
                    {
                        mailer.Credentials = new NetworkCredential(textBoxMyMail.Text, textBoxMyPassword.Text); /// email, password
                        mailer.EnableSsl = true;
                        mailer.Send(message);
                    }
                    /// CREATE COPY OF SENDED MAIL
                    TextWriter Save = new StreamWriter(yearBox.Text + MonthBox.Text + DayBox.Text + HourBox.Text + MinBox.Text + ".smail");
                    Save.WriteLine("M");
                    Save.WriteLine(yearBox.Text);
                    Save.WriteLine(MonthBox.Text);
                    Save.WriteLine(DayBox.Text); 
                    Save.WriteLine(HourBox.Text + ":" + MinBox.Text); 
                    Save.WriteLine("yes"); 
                    Save.WriteLine(textBoxMyMail.Text);
                    Save.WriteLine(textBoxMyPassword.Text);
                    Save.WriteLine(textBoxRecipent.Text);
                    Save.WriteLine(textBoxSubject.Text);
                    Save.WriteLine(textBoxBody.Text);

                    Save.Close();

                    this.Close();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(yearBox.Text) || string.IsNullOrWhiteSpace(MonthBox.Text) || string.IsNullOrWhiteSpace(DayBox.Text) || string.IsNullOrWhiteSpace(HourBox.Text) || string.IsNullOrWhiteSpace(MinBox.Text))
                    {
                        MailWindowMessageBox Message = new MailWindowMessageBox();
                        Message.Text = "Please select date for sending mail!";
                        Message.Show();
                        this.Close();
                    }
                    else
                    {
                        /// CREATE TXT FILE WITH MAIL INFORMATION AND SEND DATE
                        TextWriter Save = new StreamWriter(yearBox.Text + MonthBox.Text + DayBox.Text + HourBox.Text + MinBox.Text + ".smail");

                        Save.WriteLine("M"); 
                        Save.WriteLine(yearBox.Text); 
                        Save.WriteLine(MonthBox.Text); 
                        Save.WriteLine(DayBox.Text);
                        Save.WriteLine(HourBox.Text + ":" + MinBox.Text); 
                        Save.WriteLine("no"); /// IS MAIL SENDED?
                        Save.WriteLine(textBoxMyMail.Text);
                        Save.WriteLine(textBoxMyPassword.Text);
                        Save.WriteLine(textBoxRecipent.Text);
                        Save.WriteLine(textBoxSubject.Text);
                        for (int i = 0; i < textBoxBody.Lines.Length; i++)
                        {
                            Save.WriteLine(textBoxBody.Lines[i]);
                        }

                        Save.Close();

                        this.Close();
                    }
                }
            }


        }

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateDays();
        }

        private void yearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void AddEmailWindow_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddEmailWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
