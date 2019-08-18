using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
            CountNotes();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void Stats_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Stats_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public void CountNotes()
        {

            int notescounter = 0;
            int onotescounter = 0;

            int mailscounter = 0;
            int omaillscounter = 0;

            int eventscounter = 0;
            int oeventscounter = 0;


            string[] files = Directory.GetFiles(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            foreach(string file in files)
            {
                /// COUNT NOTES
                Match matchNotes = Regex.Match(file, @".mnote", RegexOptions.IgnoreCase);

                if (matchNotes.Success)
                {
                    notescounter++;

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

                    if (TYear >= NYear && TMonth >= NMonth && TDay >= NMonth)
                    {
                        onotescounter++;
                    }

                    int FileIndex = Array.IndexOf(files, file);
                    Array.Clear(files, FileIndex, 1);
                }
                /// COUNT EMAILS
                Match matchMails = Regex.Match(file, @".smail", RegexOptions.IgnoreCase);
                if (matchMails.Success)
                {
                    mailscounter++;

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

                    if (TYear >= NYear && TMonth >= NMonth && TDay >= NMonth)
                    {
                        omaillscounter++;
                    }

                    int FileIndex = Array.IndexOf(files, file);
                    Array.Clear(files, FileIndex, 1);

                }


                Match match = Regex.Match(file, @".mevent", RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    ///COUNT EVENTS
                    eventscounter++;

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
                        oeventscounter++;
                    }

                    int FileIndex = Array.IndexOf(files, file);
                    Array.Clear(files, FileIndex, 1);
                }
            }

            labelNotes.Text = "You have "+notescounter+" notes in which "+onotescounter+" outdated!";
            labelMails.Text = "You have "+mailscounter+" e-mails in which "+omaillscounter+" outdated!";
            labelEvents.Text = "You have "+eventscounter+" events in which "+oeventscounter+" outdated!";
            
        }
    }
}
