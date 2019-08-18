using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System.IO;
using System.Text.RegularExpressions;

namespace MyCalendar
{
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void buttonDelNotes_Click(object sender, EventArgs e)
        {
            /// DELETE NOTES WHERE DATE IS LOWER THAN TODAY DATE
            string[] files = Directory.GetFiles(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            foreach (string file in files)
            {
                Match match = Regex.Match(file, @".mnote", RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    DateTime todayDate = DateTime.Now;

                    int TDay = todayDate.Day;
                    int TMonth = todayDate.Month;
                    int TYear = todayDate.Year;

                    TextReader Load = new StreamReader(file);

                    Load.ReadLine();

                    int NYear = Convert.ToInt32(Load.ReadLine());

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

                    int NMonth = Months[Load.ReadLine()];
                    int NDay = Convert.ToInt32(Load.ReadLine());
                    Load.Close();
                    string Npath = file;

                    if (TYear >= NYear && TMonth >= NMonth && TDay >= NMonth)
                    {
                        File.Delete(Npath);
                    }

                }
            }

            SettingsMessageBox Message = new SettingsMessageBox();
            Message.Text = "Outdated Notes deleted!";
            Message.Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
        }

        private void buttonDelEmail_Click(object sender, EventArgs e)
        {
            /// DELETE EMAILS WHERE DATE IS LOWER THAN TODAY DATE
            string[] files = Directory.GetFiles(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            foreach (string file in files)
            {
                Match match = Regex.Match(file, @".smail", RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    DateTime todayDate = DateTime.Now;

                    int TDay = todayDate.Day;
                    int TMonth = todayDate.Month;
                    int TYear = todayDate.Year;

                    TextReader Load = new StreamReader(file);

                    Load.ReadLine();
                    int NYear = Convert.ToInt32(Load.ReadLine());

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

                    int NMonth = Months[Load.ReadLine()];
                    int NDay = Convert.ToInt32(Load.ReadLine());
                    Load.Close();
                    string Npath = file;

                    if (TYear >= NYear && TMonth >= NMonth && TDay >= NMonth)
                    {
                        File.Delete(Npath);
                    }
                }
            }
            SettingsMessageBox Message = new SettingsMessageBox();
            Message.Text = "Outdated E-mails deleted!";
            Message.Show();
        }

        private void buttonDelVisits_Click(object sender, EventArgs e)
        {
            /// DELETE EVENTS WHERE DATE IS LOWER THAN TODAY DATE
            string[] files = Directory.GetFiles(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            foreach (string file in files)
            {
                Match match = Regex.Match(file, @".mevent", RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    DateTime todayDate = DateTime.Now;

                    int TDay = todayDate.Day;
                    int TMonth = todayDate.Month;
                    int TYear = todayDate.Year;

                    TextReader Load = new StreamReader(file);

                    Load.ReadLine();
                    string Eyear = Load.ReadLine();
                    int NYear = Convert.ToInt32(Eyear);

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

                    string EMonth = Load.ReadLine();
                    string EDay = Load.ReadLine();
                    int NMonth = Months[EMonth];
                    int NDay = Convert.ToInt32(EDay);
                    Load.ReadLine();
                    Load.ReadLine();
                    Load.ReadLine();
                    string Name = Load.ReadLine();
                    Load.Close();
                    string Npath = file;

                    if (TYear >= NYear && TMonth >= NMonth && TDay >= NMonth)
                    {
                        /// DELETE EVENT FILE
                        File.Delete(Npath);

                        /// DELETE EVENT FROM GOOGLE CALENDAR

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

                        String calendarId = "primary";
                        String eventId = Eyear + EMonth + EDay;

                        service.Events.Delete(calendarId, eventId);
                    }
                }
            }
            SettingsMessageBox Message = new SettingsMessageBox();
            Message.Text = "Outdated visits deleted!";
            Message.Show();
        }

        private void buttonColors_Click(object sender, EventArgs e)
        {
            SettingsColorWindow SCW = new SettingsColorWindow();
            SCW.Show();
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            Stats ST = new Stats();
            ST.Show();
        }

        private void buttonSetEmail_Click(object sender, EventArgs e)
        {
            SettingsDefaultEmail SDE = new SettingsDefaultEmail();
            SDE.Show();
        }

        private void buttonConfigureGoogleCalendar_Click(object sender, EventArgs e)
        {
            SettigsEmailWindow SEW = new SettigsEmailWindow();
            SEW.BackColor = Color.SteelBlue;
            SEW.Show();
        }
    }
}
