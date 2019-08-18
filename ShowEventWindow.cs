using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class ShowEventWindow : Form
    {
        public ShowEventWindow()
        {
            InitializeComponent();
        }

        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void ShowEventWindow_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ShowEventWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public string name { set; get; }

        string sms = "No remind SMS";

        public string SMS
        {
            get
            {
                return this.SMSlabel.Text;
            }
            set
            {
                this.SMSlabel.Text = value;
            }
        }
        public string Name
        {
            get
            {
                return this.Namelabel.Text;
            }
            set
            {
                this.Namelabel.Text = value;
            }
        }
        public string Location
        {
            get
            {
                return this.Locationllabel.Text;
            }
            set
            {
                this.Locationllabel.Text = value;
            }
        }
        public string StartDate
        {
            get
            {
                return this.Startlabel.Text;
            }
            set
            {
                this.Startlabel.Text = value;
            }
        }
        public string EndDate
        {
            get
            {
                return this.Endlabel.Text;
            }
            set
            {
                this.Endlabel.Text = value;
            }
        }
        public string Description
        {
            get
            {
                return this.Descriptionlabel.Text;
            }
            set
            {
                this.Descriptionlabel.Text = value;
            }
        }



        public static void DeleteEvent(CalendarService service, Event eventToDelete, string calendarId = "primary")
        {
            service.Events.Delete(calendarId, eventToDelete.Id);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MailWindowMessageBox Message = new MailWindowMessageBox();
            /*  TO USE WHEN LEARN HOW TO ENCODE GOOGLE EVENT ID 
            File.Delete(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + name + ".mevent");
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
            String eventId = name;

            service.Events.Delete(calendarId, eventId);
            */
            File.Delete(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + name + ".mevent");
            Message.Text = "Visit deleted from Google Calendar!";
            Message.Show();
            this.Close();
        }
    }
}
