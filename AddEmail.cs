using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace MyCalendar
{
    public partial class AddEmail : UserControl
    {
        public AddEmail()
        {
            InitializeComponent();
            GenerateMonth();
            GenerateDays();
            GenerateTodayDay();
            SetDefaultEmail();
        }

        public void SetDefaultEmail()
        {
            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\personal.setting"))
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

        private void SendButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxMyMail.Text) || string.IsNullOrWhiteSpace(textBoxMyPassword.Text) || string.IsNullOrWhiteSpace(textBoxRecipent.Text) || string.IsNullOrWhiteSpace(textBoxSubject.Text) || string.IsNullOrWhiteSpace(textBoxBody.Text))
            {
                MailWindowMessageBox Message = new MailWindowMessageBox();
                Message.Text = "Please set all information in Window!";
                Message.Show();
            }
            else
            {

                if (checkBoxNow.CheckState == CheckState.Checked)
                {
                    try
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

                        MailWindowMessageBox Message = new MailWindowMessageBox();
                        Message.Text = "Message Send!";
                        Message.Show();

                        Save.Close();
                    }
                    catch(Exception ex)
                    {
                        MailWindowMessageBox Message = new MailWindowMessageBox();
                        Message.Text = "Mail not Send!";
                        Message.Show();
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(yearBox.Text) || string.IsNullOrWhiteSpace(MonthBox.Text) || string.IsNullOrWhiteSpace(DayBox.Text) || string.IsNullOrWhiteSpace(HourBox.Text) || string.IsNullOrWhiteSpace(MinBox.Text))
                    {
                        MailWindowMessageBox Message = new MailWindowMessageBox();
                        Message.Text = "Please select date for sending mail!";
                        Message.Show();
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
                        MailWindowMessageBox Message = new MailWindowMessageBox();
                        Message.Text = "Mail added to queue!";
                        Message.Show();

                    }
                }
            }
        }
    }
}
