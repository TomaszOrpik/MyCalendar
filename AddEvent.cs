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
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;
using Google.Apis.Auth.OAuth2;

namespace MyCalendar
{
    public partial class AddEvent : UserControl
    {
        public AddEvent()
        {
            /// FIRST SCRIPT SELECT MONTH, THAN GENERATE NUMBER OF DAYS, THAN SELECT TODAY
            InitializeComponent();
            GenerateMonth();
            GenerateDays();
            GenerateTodayDay();
            GenerateMonth1();
            GenerateDays1();
            GenerateTodayDay1();
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

        private void yearBox1_KeyPress(object sender, KeyPressEventArgs e)
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
        /// GENERATE DAYS, MONTHS, HOURS AND MINS FOR START TIME
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

        /// GENERATE DAYS, MONTHS, HOURS AND MINS FOR END TIME
        public void GenerateDays1()
        {
            string year = yearBox1.Text;
            int y = 0;
            Int32.TryParse(year, out y);
            string month = MonthBox1.Text;

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

            DayBox1.Items.Clear();

            for (int x = 0; x < days; x++)
            {
                DayBox1.Items.Add(Convert.ToString(day));
                day++;
            }
            int hour = 0;

            HourBox1.Items.Clear();

            for (int x = 0; x < 24; x++)
            {
                HourBox1.Items.Add(hour.ToString("D2"));
                hour++;
            }

            int minut = 0;

            MinBox1.Items.Clear();

            for (int x = 0; x < 60; x++)
            {
                MinBox1.Items.Add(minut.ToString("D2"));
                minut++;
            }

        }

        public void GenerateMonth1()
        {
            DateTime TodayDate1 = DateTime.Now;

            int NowMonth = TodayDate1.Month;
            MonthBox1.SelectedIndex = NowMonth - 1;

            int NowYear = TodayDate1.Year;
            yearBox1.Text = Convert.ToString(NowYear);



        }

        public void GenerateTodayDay1()
        {
            DateTime TodayDate1 = DateTime.Now;


            int NowDay = TodayDate1.Day;
            DayBox1.SelectedIndex = NowDay - 1;

            int NowHour = TodayDate1.Hour;
            HourBox1.SelectedIndex = NowHour;

            int NowMinutes = TodayDate1.Minute;
            MinBox1.SelectedIndex = NowMinutes;
        }

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateDays();
        }

        private void MonthBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateDays1();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\myID.setting") == false)
            {
                ///OPEN WINDOW WITH CALENDAR CONFIGURATION AND SET STRING myID

                AddEventMassagebox message = new AddEventMassagebox();
                message.Text = "Please configure calendar and try again!";
                message.Show();
                ///OPEN CONFIGURE SCREEN

                SettigsEmailWindow SEW = new SettigsEmailWindow();
                SEW.Show();
                this.Hide();
                return;

            }
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxLocation.Text) || string.IsNullOrWhiteSpace(DescriptionBox.Text))
            {
                AddEventMassagebox message = new AddEventMassagebox();
                message.Text = "Please fill all the positions!";
                message.Show();
            }
            else
            {
                TextReader setid = new StreamReader(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\myID.setting");
                string curID = setid.ReadLine();
                string curSecret = setid.ReadLine();
                string curProID = setid.ReadLine();
                string curMail = setid.ReadLine();
                setid.Close();


                TextWriter credentials = new StreamWriter("credentials.json");
                /// change project id and maybe client secret
                credentials.WriteLine("{\"installed\":{\"client_id\":\"" + curID + "\",\"project_id\":\"" + curProID + "\",\"auth_uri\":\"https://accounts.google.com/o/oauth2/auth\",\"token_uri\":\"https://oauth2.googleapis.com/token\",\"auth_provider_x509_cert_url\":\"https://www.googleapis.com/oauth2/v1/certs\",\"client_secret\":\"" + curSecret + "\",\"redirect_uris\":[\"urn:ietf:wg:oauth:2.0:oob\",\"http://localhost\"]}}");
                credentials.Close();

                string[] Scopes = { CalendarService.Scope.Calendar };
                string ApplicationName = "MyCalendar Google Calendar API";


                UserCredential credential;

                using (var stream =
                    new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    // The file token.json stores the user's access and refresh tokens, and is created
                    // automatically when the authorization flow completes for the first time.
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }

                // Create Google Calendar API service.
                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

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

                int Hourint = Convert.ToInt32(HourBox.Text);
                int Minint = Convert.ToInt32(MinBox.Text);


                string month1 = MonthBox1.Text;

                Dictionary<string, int> Months1 = new Dictionary<string, int>();

                Months1.Add("January", 1);
                Months1.Add("February", 2);
                Months1.Add("March", 3);
                Months1.Add("April", 4);
                Months1.Add("May", 5);
                Months1.Add("June", 6);
                Months1.Add("July", 7);
                Months1.Add("August", 8);
                Months1.Add("September", 9);
                Months1.Add("October", 10);
                Months1.Add("November", 11);
                Months1.Add("December", 12);

                int MM = Months1[month1];

                int Hourint1 = Convert.ToInt32(HourBox1.Text);
                int Minint1 = Convert.ToInt32(MinBox1.Text);

                int RemindTime = 0;

                ChangeReminder();

                void ChangeReminder()
                {
                    if (Convert.ToBoolean(checkBoxReminder.CheckState = CheckState.Checked))
                        RemindTime = 10;
                }


                Event newEvent = new Event()
                {
                    ///Id = Convert.ToString(yearBox.Text + MonthBox.Text + DayBox.Text),
                    Summary = textBoxName.Text,
                    Location = textBoxLocation.Text,
                    Description = DescriptionBox.Text,
                    Start = new EventDateTime()
                    {
                        DateTime = DateTime.Parse(yearBox.Text + "-" + M.ToString("D2") + "-" + DayBox.Text + "T" + Hourint.ToString("D2") + ":" + Minint.ToString("D2") + ":00-07:00"),
                        TimeZone = "Europe/Warsaw",
                    },
                    End = new EventDateTime()
                    {
                        DateTime = DateTime.Parse(yearBox1.Text + "-" + MM.ToString("D2") + "-" + DayBox1.Text + "T" + Hourint1.ToString("D2") + ":" + Minint1.ToString("D2") + ":00-07:00"),
                        TimeZone = "Europe/Warsaw",
                    },

                    Attendees = new EventAttendee[] {
        new EventAttendee() {
            Organizer = true,
            Email = curMail,
        ResponseStatus = "accepted" }, /// automaticly confirmed
                },

                    Reminders = new Event.RemindersData()
                    {
                        UseDefault = false,
                        Overrides = new EventReminder[] {
            new EventReminder() { Method = "sms", Minutes = RemindTime },
        }
                    }

                };



                String calendarId = "primary";
                EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
                Event createdEvent = request.Execute();

                /// CREATE NOTE WITH SAVED EVENT

                TextWriter eventnote = new StreamWriter(yearBox.Text + MonthBox.Text + DayBox.Text + HourBox.Text + MinBox.Text + ".mevent");
                eventnote.WriteLine("E");
                eventnote.WriteLine(yearBox.Text);
                eventnote.WriteLine(MonthBox.Text);
                eventnote.WriteLine(DayBox.Text);
                eventnote.WriteLine(HourBox.Text + ":" + MinBox.Text);
                eventnote.WriteLine(yearBox1.Text + "/" + MonthBox1.Text + "/" + DayBox1.Text + " " + HourBox1.Text + ":" + MinBox1.Text);
                if (checkBoxReminder.CheckState == CheckState.Checked)
                    eventnote.WriteLine("yes");
                else
                    eventnote.WriteLine("no");
                eventnote.WriteLine(textBoxName.Text);
                eventnote.WriteLine(textBoxLocation.Text);

                ///ADDING DESCRIPTION WITH MULTILINES
                for (int i = 0; i < DescriptionBox.Lines.Length; i++)
                {
                    eventnote.WriteLine(DescriptionBox.Lines[i] + "\n");
                }

                eventnote.Close();
                AddEventMassagebox Message = new AddEventMassagebox();
                Message.Text = "Event Added!";
                Message.Show();

            }
        }
        bool Nameclick = false;
        bool Locclick = false;
        bool Desclick = false;

        private void textBoxName_MouseClick(object sender, MouseEventArgs e)
        {
            if(!Nameclick)
            {
                textBoxName.Text = "";
                Nameclick = true;
            }
        }

        private void textBoxLocation_MouseClick(object sender, MouseEventArgs e)
        {
            if(!Locclick)
            {
                textBoxLocation.Text = "";
                Locclick = true;
            }
        }

        private void DescriptionBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(!Desclick)
            {
                DescriptionBox.Text = "";
                Desclick = true;
            }
        }
    }
}
