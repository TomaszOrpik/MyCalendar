using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoreLinq.Extensions;
using MyCalendar.Properties;

namespace MyCalendar
{
   public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            /// SET WINDOW LOCATION
            if(Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }

            /// HIDE ALL USER CONTROLS
            addNote1.Hide();
            addEmail1.Hide();
            addEvent1.Hide();
            setting1.Hide();

            LoadingColors();
            SetColor();
            GenerateMonth();
            Timer.Start();

            /// TOOLTIPS FOR BUTTONS
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.buttonAddNote, "Add New Note");

            ToolTip ToolTip2 = new ToolTip();
            ToolTip2.SetToolTip(this.buttonSendEmail, "Send New E-mail");

            ToolTip ToolTip3 = new ToolTip();
            ToolTip3.SetToolTip(this.buttonAddVisit, "Create New Visit");

            ToolTip ToolTip4 = new ToolTip();
            ToolTip4.SetToolTip(this.buttonSettings, "Change Calendar Settings");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /// COPY WINDOW LOCATION TO APP SETTINGS
            Settings.Default.WindowLocation = this.Location;
            Settings.Default.Save();
        }

        /// VISUAL SECTION

            /// DEFAULT COLOR SETTINGS
        string BackgroundColor = "White          ";
        string DaysColor = "White          ";
        string BusyDayColor = "Green          ";
        string TodayDayColor = "Blue          ";
        
        public void SetColor()
        {
            switch (BackgroundColor)
            {
                case "White          ":
                    panelCalendar.BackColor = Color.White;

                    Clock.ForeColor = Color.Black;

                    labelM.ForeColor = Color.Black;
                    labelTu.ForeColor = Color.Black;
                    labelW.ForeColor = Color.Black;
                    labelTh.ForeColor = Color.Black;
                    labelF.ForeColor = Color.Black;
                    labelSt.ForeColor = Color.Black;

                    textBoxYear.ForeColor = Color.Black;
                    textBoxYear.BackColor = Color.White;

                    comboBoxMonth.ForeColor = Color.Black;
                    comboBoxMonth.BackColor = Color.White;

                    buttonPrevMonth.ForeColor = Color.Black;
                    buttonPrevMonth.BackColor = Color.White;

                    buttonNextMonth.ForeColor = Color.Black;
                    buttonNextMonth.BackColor = Color.White;
                    break;
                case "Black          ":
                    panelCalendar.BackColor = Color.Black;

                    Clock.ForeColor = Color.White;

                    labelM.ForeColor = Color.White;
                    labelTu.ForeColor = Color.White;
                    labelW.ForeColor = Color.White;
                    labelTh.ForeColor = Color.White;
                    labelF.ForeColor = Color.White;
                    labelSt.ForeColor = Color.White;

                    textBoxYear.ForeColor = Color.White;
                    textBoxYear.BackColor = Color.Black;

                    comboBoxMonth.ForeColor = Color.White;
                    comboBoxMonth.BackColor = Color.Black;

                    buttonPrevMonth.ForeColor = Color.White;
                    buttonPrevMonth.BackColor = Color.Black;

                    buttonNextMonth.ForeColor = Color.White;
                    buttonNextMonth.BackColor = Color.Black;
                    break;
                case "Gray          ":
                    panelCalendar.BackColor = Color.DimGray;

                    Clock.ForeColor = Color.Black;

                    labelM.ForeColor = Color.Black;
                    labelTu.ForeColor = Color.Black;
                    labelW.ForeColor = Color.Black;
                    labelTh.ForeColor = Color.Black;
                    labelF.ForeColor = Color.Black;
                    labelSt.ForeColor = Color.Black;

                    textBoxYear.ForeColor = Color.Black;
                    textBoxYear.BackColor = Color.DimGray;

                    comboBoxMonth.ForeColor = Color.Black;
                    comboBoxMonth.BackColor = Color.DimGray;

                    buttonPrevMonth.ForeColor = Color.Black;
                    buttonPrevMonth.BackColor = Color.DimGray;

                    buttonNextMonth.ForeColor = Color.Black;
                    buttonNextMonth.BackColor = Color.DimGray;
                    break;
                case "Yellow          ":
                    panelCalendar.BackColor = Color.Yellow;

                    Clock.ForeColor = Color.Black;

                    labelM.ForeColor = Color.Black;
                    labelTu.ForeColor = Color.Black;
                    labelW.ForeColor = Color.Black;
                    labelTh.ForeColor = Color.Black;
                    labelF.ForeColor = Color.Black;
                    labelSt.ForeColor = Color.Black;

                    textBoxYear.ForeColor = Color.Black;
                    textBoxYear.BackColor = Color.Yellow;

                    comboBoxMonth.ForeColor = Color.Black;
                    comboBoxMonth.BackColor = Color.Yellow;

                    buttonPrevMonth.ForeColor = Color.Black;
                    buttonPrevMonth.BackColor = Color.Yellow;

                    buttonNextMonth.ForeColor = Color.Black;
                    buttonNextMonth.BackColor = Color.Yellow;
                    break;
                case "Orange          ":
                    panelCalendar.BackColor = Color.Orange;

                    Clock.ForeColor = Color.Black;

                    labelM.ForeColor = Color.Black;
                    labelTu.ForeColor = Color.Black;
                    labelW.ForeColor = Color.Black;
                    labelTh.ForeColor = Color.Black;
                    labelF.ForeColor = Color.Black;
                    labelSt.ForeColor = Color.Black;

                    textBoxYear.ForeColor = Color.Black;
                    textBoxYear.BackColor = Color.Orange;

                    comboBoxMonth.ForeColor = Color.Black;
                    comboBoxMonth.BackColor = Color.Orange;

                    buttonPrevMonth.ForeColor = Color.Black;
                    buttonPrevMonth.BackColor = Color.Orange;

                    buttonNextMonth.ForeColor = Color.Black;
                    buttonNextMonth.BackColor = Color.Orange;
                    break;
                case "Red          ":
                    panelCalendar.BackColor = Color.Red;

                    Clock.ForeColor = Color.Black;

                    labelM.ForeColor = Color.Black;
                    labelTu.ForeColor = Color.Black;
                    labelW.ForeColor = Color.Black;
                    labelTh.ForeColor = Color.Black;
                    labelF.ForeColor = Color.Black;
                    labelSt.ForeColor = Color.Black;

                    textBoxYear.ForeColor = Color.Black;
                    textBoxYear.BackColor = Color.Red;

                    comboBoxMonth.ForeColor = Color.Black;
                    comboBoxMonth.BackColor = Color.Red;

                    buttonPrevMonth.ForeColor = Color.Black;
                    buttonPrevMonth.BackColor = Color.Red;

                    buttonNextMonth.ForeColor = Color.Black;
                    buttonNextMonth.BackColor = Color.Red;
                    break;
                case "Blue          ":
                    panelCalendar.BackColor = Color.Blue;

                    Clock.ForeColor = Color.Black;

                    labelM.ForeColor = Color.Black;
                    labelTu.ForeColor = Color.Black;
                    labelW.ForeColor = Color.Black;
                    labelTh.ForeColor = Color.Black;
                    labelF.ForeColor = Color.Black;
                    labelSt.ForeColor = Color.Black;

                    textBoxYear.ForeColor = Color.Black;
                    textBoxYear.BackColor = Color.Blue;

                    comboBoxMonth.ForeColor = Color.Black;
                    comboBoxMonth.BackColor = Color.Blue;

                    buttonPrevMonth.ForeColor = Color.Black;
                    buttonPrevMonth.BackColor = Color.Blue;

                    buttonNextMonth.ForeColor = Color.Black;
                    buttonNextMonth.BackColor = Color.Blue;
                    break;
                case "Green          ":
                    panelCalendar.BackColor = Color.Green;

                    Clock.ForeColor = Color.Black;

                    labelM.ForeColor = Color.Black;
                    labelTu.ForeColor = Color.Black;
                    labelW.ForeColor = Color.Black;
                    labelTh.ForeColor = Color.Black;
                    labelF.ForeColor = Color.Black;
                    labelSt.ForeColor = Color.Black;

                    textBoxYear.ForeColor = Color.Black;
                    textBoxYear.BackColor = Color.Green;

                    comboBoxMonth.ForeColor = Color.Black;
                    comboBoxMonth.BackColor = Color.Green;

                    buttonPrevMonth.ForeColor = Color.Black;
                    buttonPrevMonth.BackColor = Color.Green;

                    buttonNextMonth.ForeColor = Color.Black;
                    buttonNextMonth.BackColor = Color.Green;
                    break;
                case "Violet          ":
                    panelCalendar.BackColor = Color.Violet;

                    Clock.ForeColor = Color.Black;

                    labelM.ForeColor = Color.Black;
                    labelTu.ForeColor = Color.Black;
                    labelW.ForeColor = Color.Black;
                    labelTh.ForeColor = Color.Black;
                    labelF.ForeColor = Color.Black;
                    labelSt.ForeColor = Color.Black;

                    textBoxYear.ForeColor = Color.Black;
                    textBoxYear.BackColor = Color.Violet;

                    comboBoxMonth.ForeColor = Color.Black;
                    comboBoxMonth.BackColor = Color.Violet;

                    buttonPrevMonth.ForeColor = Color.Black;
                    buttonPrevMonth.BackColor = Color.Violet;

                    buttonNextMonth.ForeColor = Color.Black;
                    buttonNextMonth.BackColor = Color.Violet;
                    break;
                case "Pink          ":
                    panelCalendar.BackColor = Color.Pink;

                    Clock.ForeColor = Color.Black;

                    labelM.ForeColor = Color.Black;
                    labelTu.ForeColor = Color.Black;
                    labelW.ForeColor = Color.Black;
                    labelTh.ForeColor = Color.Black;
                    labelF.ForeColor = Color.Black;
                    labelSt.ForeColor = Color.Black;

                    textBoxYear.ForeColor = Color.Black;
                    textBoxYear.BackColor = Color.Pink;

                    comboBoxMonth.ForeColor = Color.Black;
                    comboBoxMonth.BackColor = Color.Pink;

                    buttonPrevMonth.ForeColor = Color.Black;
                    buttonPrevMonth.BackColor = Color.Pink;

                    buttonNextMonth.ForeColor = Color.Black;
                    buttonNextMonth.BackColor = Color.Pink;
                    break;
                
            }
        }


        /// FUNCTIONS SECTION

            /// LOAD SETTINGS OF CALENDAR COLORS 
        public void LoadingColors()
        { 
            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\color.setting"))
            {
                TextReader Load = new StreamReader(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\color.setting");

                BackgroundColor = Load.ReadLine();
                DaysColor = Load.ReadLine();
                BusyDayColor = Load.ReadLine();
                TodayDayColor = Load.ReadLine();

                Load.Close();
            }
        }

        /// CREATES LIST FOR DATES ALREADY GENERATED

        List<string> UsedMonths = new List<string>();

        List<string> UsedYears = new List<string>();


        /// GENERATE CALENDAR FUNCTION - CENTER
        public void generatecalendar()
        {

            string year = textBoxYear.Text;
            int y = 0;
            Int32.TryParse(year, out y);
            string month = comboBoxMonth.Text;

            ///ARRAY WITH BUTTONS

            Button[] buttons = new Button[] {button1,  button2,  button3,  button4,  button5,  button6,  button7,  button8,  button9,  button10,
                                             button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
                                             button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
                                             button31, button32, button33, button34, button35, button36, button37, button38, button39, button40,
                                             button41, button42 };

            int b = 0; /// BUTTON INDEX

            ///RESET BUTTON TEXT AND COLORS 
            for (int e = 0; e < 42; e++)
            {
                buttons[b].Text = "";
                buttons[b].BackColor = Color.LightGray;
                b++;
            }

            ///RESET BUTTON INDEX
            b = 0;

            ///DICTIONARY WITH MONTHS LIST

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
            int d = 0;

            DateTime dateValue = new DateTime(y, M, 1);
            string dayofweek = dateValue.ToString("ddd", CultureInfo.CreateSpecificCulture("en-US"));

            switch (dayofweek)
            {
                case "Mon":
                    button1.Text = "1";
                    button1.BackColor = Color.White;
                    b = 1;
                    d = 0;
                    break;

                case "Tue":
                    button2.Text = "1";
                    button2.BackColor = Color.White;
                    b = 2;
                    d = 1;
                    break;

                case "Wed":
                    button3.Text = "1";
                    button3.BackColor = Color.White;
                    b = 3;
                    d = 2;
                    break;

                case "Thu":
                    button4.Text = "1";
                    button4.BackColor = Color.White;
                    b = 4;
                    d = 3;
                    break;

                case "Fri":
                    button5.Text = "1";
                    button5.BackColor = Color.White;
                    b = 5;
                    d = 4;
                    break;

                case "Sat":
                    button6.Text = "1";
                    button6.BackColor = Color.White;
                    b = 6;
                    d = 5;
                    break;

                case "Sun":
                    button7.Text = "1";
                    button7.BackColor = Color.White;
                    b = 7;
                    d = 6;
                    break;
                    
            }

            /// GENERATE PREV MONTH DAYS
            int f = 0;
            int P = M - 1;
            if (M == 1)
                P = 12;
            int LMday = DateTime.DaysInMonth(y, P);
            int startLMday = ((LMday - d)+1);
            for(int i=startLMday; i<=LMday; i++)
            {
                buttons[f].Text = Convert.ToString(i);
                buttons[f].ForeColor = Color.Black;
                f++;
            }


            int c = 2;
            /// PRINT ALL DAYS OF MONTH
            int days = DateTime.DaysInMonth(y, M);

            switch (DaysColor)
            {
                case "White          ":
                    buttons[b - 1].BackColor = Color.White;
                    buttons[b - 1].ForeColor = Color.Black;
                    for (int a = 1; a < days; a++)
                    {
                        buttons[b].Text = Convert.ToString(c);
                        buttons[b].BackColor = Color.White;
                        buttons[b].ForeColor = Color.Black;
                        b++;
                        c++;
                    }
                    break;
                case "Black          ":
                    buttons[b - 1].BackColor = Color.Black;
                    buttons[b - 1].ForeColor = Color.White;
                    for (int a = 1; a < days; a++)
                    {
                        buttons[b].Text = Convert.ToString(c);
                        buttons[b].BackColor = Color.Black;
                        buttons[b].ForeColor = Color.White; ;
                        b++;
                        c++;
                    }
                    break;
                case "Gray          ":
                    buttons[b - 1].BackColor = Color.DimGray;
                    buttons[b - 1].ForeColor = Color.Black;
                    for (int a = 1; a < days; a++)
                    {
                        buttons[b].Text = Convert.ToString(c);
                        buttons[b].BackColor = Color.DimGray;
                        buttons[b].ForeColor = Color.Black;
                        b++;
                        c++;
                    }
                    break;
                case "Yellow          ":
                    buttons[b - 1].BackColor = Color.Yellow;
                    buttons[b - 1].ForeColor = Color.Black;
                    for (int a = 1; a < days; a++)
                    {
                        buttons[b].Text = Convert.ToString(c);
                        buttons[b].BackColor = Color.Yellow;
                        buttons[b].ForeColor = Color.Black;
                        b++;
                        c++;
                    }
                    break;
                case "Orange          ":
                    buttons[b - 1].BackColor = Color.Orange;
                    buttons[b - 1].ForeColor = Color.Black;
                    for (int a = 1; a < days; a++)
                    {
                        buttons[b].Text = Convert.ToString(c);
                        buttons[b].BackColor = Color.Orange;
                        buttons[b].ForeColor = Color.Black;
                        b++;
                        c++;
                    }
                    break;
                case "Red          ":
                    buttons[b - 1].BackColor = Color.Red;
                    buttons[b - 1].ForeColor = Color.Black;
                    for (int a = 1; a < days; a++)
                    {
                        buttons[b].Text = Convert.ToString(c);
                        buttons[b].BackColor = Color.Red;
                        buttons[b].ForeColor = Color.Black;
                        b++;
                        c++;
                    }
                    break;
                case "Blue          ":
                    buttons[b - 1].BackColor = Color.Blue;
                    buttons[b - 1].ForeColor = Color.Black;
                    for (int a = 1; a < days; a++)
                    {
                        buttons[b].Text = Convert.ToString(c);
                        buttons[b].BackColor = Color.Blue;
                        buttons[b].ForeColor = Color.Black;
                        b++;
                        c++;
                    }
                    break;
                case "Green          ":
                    buttons[b - 1].BackColor = Color.Green;
                    buttons[b - 1].ForeColor = Color.Black;
                    for (int a = 1; a < days; a++)
                    {
                        buttons[b].Text = Convert.ToString(c);
                        buttons[b].BackColor = Color.Green;
                        buttons[b].ForeColor = Color.Black;
                        b++;
                        c++;
                    }
                    break;
                case "Violet          ":
                    buttons[b - 1].BackColor = Color.Violet;
                    buttons[b - 1].ForeColor = Color.Black;
                    for (int a = 1; a < days; a++)
                    {
                        buttons[b].Text = Convert.ToString(c);
                        buttons[b].BackColor = Color.Violet;
                        buttons[b].ForeColor = Color.Black;
                        b++;
                        c++;
                    }
                    break;
                case "Pink          ":
                    buttons[b - 1].BackColor = Color.Pink;
                    buttons[b - 1].ForeColor = Color.Black;
                    for (int a = 1; a < days; a++)
                    {
                        buttons[b].Text = Convert.ToString(c);
                        buttons[b].BackColor = Color.Pink;
                        buttons[b].ForeColor = Color.Black;
                        b++;
                        c++;
                    }
                    break;

            }

            /// SET RED COLOR FOR SUNDAY
            if (DaysColor == "Red          ")
            {
                button7.ForeColor = Color.Black;
                button14.ForeColor = Color.Black;
                button21.ForeColor = Color.Black;
                button28.ForeColor = Color.Black;
                button35.ForeColor = Color.Black;
                button42.ForeColor = Color.Black;
            }
            else
            {
                button7.ForeColor = Color.Red;
                button14.ForeColor = Color.Red;
                button21.ForeColor = Color.Red;
                button28.ForeColor = Color.Red;
                button35.ForeColor = Color.Red;
                button42.ForeColor = Color.Red;

            }

            /// PRINT DAYS FOR NEXT MONTH
            int PrevDays = 1;
            for(int i = (days+d); i < 42; i++)
            {
                buttons[i].Text = Convert.ToString(PrevDays);
                buttons[i].ForeColor = Color.Black;
                PrevDays++;
            }

            DateTime todayDate = DateTime.Now;

            string todayMonthYear = todayDate.ToString("M yyyy");
            int todayDay = todayDate.Day;
            /// SELECT TODAY DATE

            switch (TodayDayColor)
            {
                case "White          ":
                    if (Convert.ToString(M) + " " + Convert.ToString(y) == todayMonthYear)
                    {
                        buttons[(todayDay + d) - 1].BackColor = Color.White;
                        buttons[(todayDay + d) - 1].ForeColor = Color.Black;
                    }
                    break;
                case "Black          ":
                    if (Convert.ToString(M) + " " + Convert.ToString(y) == todayMonthYear)
                    {
                        buttons[(todayDay + d) - 1].BackColor = Color.Black;
                        buttons[(todayDay + d) - 1].ForeColor = Color.White;
                    }
                    break;
                case "Gray          ":
                    if (Convert.ToString(M) + " " + Convert.ToString(y) == todayMonthYear)
                    {
                        buttons[(todayDay + d) - 1].BackColor = Color.DimGray;
                        buttons[(todayDay + d) - 1].ForeColor = Color.Black;
                    }
                    break;
                case "Yellow          ":
                    if (Convert.ToString(M) + " " + Convert.ToString(y) == todayMonthYear)
                    {
                        buttons[(todayDay + d) - 1].BackColor = Color.Yellow;
                        buttons[(todayDay + d) - 1].ForeColor = Color.Black;
                    }
                    break;
                case "Orange          ":
                    if (Convert.ToString(M) + " " + Convert.ToString(y) == todayMonthYear)
                    {
                        buttons[(todayDay + d) - 1].BackColor = Color.Orange;
                        buttons[(todayDay + d) - 1].ForeColor = Color.Black;
                    }
                    break;
                case "Red          ":
                    if (Convert.ToString(M) + " " + Convert.ToString(y) == todayMonthYear)
                    {
                        buttons[(todayDay + d) - 1].BackColor = Color.Red;
                        buttons[(todayDay + d) - 1].ForeColor = Color.Black;
                    }
                    break;
                case "Blue          ":
                    if (Convert.ToString(M) + " " + Convert.ToString(y) == todayMonthYear)
                    {
                        buttons[(todayDay + d) - 1].BackColor = Color.Blue;
                        buttons[(todayDay + d) - 1].ForeColor = Color.Black;
                    }
                    break;
                case "Green          ":
                    if (Convert.ToString(M) + " " + Convert.ToString(y) == todayMonthYear)
                    {
                        buttons[(todayDay + d) - 1].BackColor = Color.Green;
                        buttons[(todayDay + d) - 1].ForeColor = Color.Black;
                    }
                    break;
                case "Violet          ":
                    if (Convert.ToString(M) + " " + Convert.ToString(y) == todayMonthYear)
                    {
                        buttons[(todayDay + d) - 1].BackColor = Color.Violet;
                        buttons[(todayDay + d) - 1].ForeColor = Color.Black;
                    }
                    break;
                case "Pink          ":
                    if (Convert.ToString(M) + " " + Convert.ToString(y) == todayMonthYear)
                    {
                        buttons[(todayDay + d) - 1].BackColor = Color.Pink;
                        buttons[(todayDay + d) - 1].ForeColor = Color.Black;
                    }
                    break;

            }

            /// CREATES ARRAY OF FILES IN EXE DIRECTORY

            string[] files = Directory.GetFiles(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            List<int> BusyDays = new List<int>();

            foreach (string file in files)
            {
                /// START NOTES READING
                Match match = Regex.Match(file, @".mnote", RegexOptions.IgnoreCase);
                if (match.Success)
                {

                    TextReader Load = new StreamReader(file);

                    Load.ReadLine();

                    if (textBoxYear.Text == Load.ReadLine() && comboBoxMonth.Text == Load.ReadLine())
                    {
                        string NoteDay = Load.ReadLine();
                        string NoteTime = Load.ReadLine();
                        int Noteday = ((Convert.ToInt32(NoteDay)) + d) - 1;
                        Load.ReadLine();
                        string NoteRemind = Load.ReadLine();


                        if (Convert.ToInt32(NoteDay) == todayDay)
                        {
                            /// IF REMINDER IS SET FOR TODAY

                            if (NoteRemind == "1")
                            {
                                Reminders.Add(NoteTime);
                            }
                        }
                        BusyDays.Add(Noteday);
                    }
                    Load.Close();
                } 
                /// MAIL FILES READING 
                Match matchmail = Regex.Match(file, @".smail", RegexOptions.IgnoreCase);
                if (matchmail.Success)
                {
                    TextReader Load = new StreamReader(file);

                    Load.ReadLine();

                    if (textBoxYear.Text == Load.ReadLine() && comboBoxMonth.Text == Load.ReadLine())
                    {

                        string MailDay = Load.ReadLine();
                        int Mailday = ((Convert.ToInt32(MailDay)) + d) - 1;
                        string MailTime = Load.ReadLine();
                        string Sended = Load.ReadLine();

                        if (Convert.ToInt32(MailDay) == todayDay)
                        {
                            if (Sended == "no")
                            {
                                Sender.Add(MailTime);
                            }
                        }
                        BusyDays.Add(Mailday);
                    }
                    Load.Close();
                }   
                /// READ EVENTS
                Match matchevent = Regex.Match(file, @".mevent", RegexOptions.IgnoreCase);
                if(matchevent.Success)
                {
                    TextReader Load = new StreamReader(file);

                    Load.ReadLine();

                    if (textBoxYear.Text == Load.ReadLine() && comboBoxMonth.Text == Load.ReadLine())
                    {

                        string EventDay = Load.ReadLine();
                        int Eventday = ((Convert.ToInt32(EventDay)) + d) - 1;

                        BusyDays.Add(Eventday);
                    }
                    Load.Close();
                }

            }

            List<int> BusyDaysDistinct = BusyDays.Distinct().ToList();
            
            /// TAKES DAY WITH NOTE FROM READFILES GENERATES CLICK SENDER FOR BUTTON WITH THIS DAY AND CHECKS IF BUTTON WAS ALREADY GENERATED
            switch (BusyDayColor)
            {
                case "White          ":
                    foreach(int busyday in BusyDaysDistinct)
                    {
                        int day = busyday;

                        if(day > 0)
                        {
                            buttons[day].BackColor = Color.White;
                            buttons[day].ForeColor = Color.Black;

                            if (UsedYears.Contains(textBoxYear.Text+Convert.ToString(day)) == false && UsedMonths.Contains(comboBoxMonth.Text+Convert.ToString(day)) == false)
                            {
                                buttons[day].Click += (sender, e) => { Day_Click(sender, e, day - 1); };
                                UsedYears.Add(textBoxYear.Text+Convert.ToString(day));
                                UsedMonths.Add(comboBoxMonth.Text+Convert.ToString(day));
                            }
                        }
                    }
                    break;
                case "Black          ":
                    foreach (int busyday in BusyDaysDistinct)
                    {
                        int day = busyday;

                        if (day > 0)
                        {
                            buttons[day].BackColor = Color.Black;
                            buttons[day].ForeColor = Color.White;

                            if (UsedYears.Contains(textBoxYear.Text+Convert.ToString(day)) == false && UsedMonths.Contains(comboBoxMonth.Text + Convert.ToString(day)) == false)
                            {
                                buttons[day].Click += (sender, e) => { Day_Click(sender, e, day - 1); };
                                UsedYears.Add(textBoxYear.Text + Convert.ToString(day));
                                UsedMonths.Add(comboBoxMonth.Text + Convert.ToString(day));
                            }
                        }
                    }
                    break;
                case "Gray          ":
                    foreach (int busyday in BusyDaysDistinct)
                    {
                        int day = busyday;

                        if (day > 0)
                        {
                            buttons[day].BackColor = Color.DimGray;
                            buttons[day].ForeColor = Color.Black;

                            if (UsedYears.Contains(textBoxYear.Text + Convert.ToString(day)) == false && UsedMonths.Contains(comboBoxMonth.Text + Convert.ToString(day)) == false)
                            {
                                buttons[day].Click += (sender, e) => { Day_Click(sender, e, day - 1); };
                                UsedYears.Add(textBoxYear.Text + Convert.ToString(day));
                                UsedMonths.Add(comboBoxMonth.Text + Convert.ToString(day));
                            }
                        }
                    }
                    break;
                case "Yellow          ":
                    foreach (int busyday in BusyDaysDistinct)
                    {
                        int day = busyday;

                        if (day > 0)
                        {
                            buttons[day].BackColor = Color.Yellow;
                            buttons[day].ForeColor = Color.Black;

                            if (UsedYears.Contains(textBoxYear.Text + Convert.ToString(day)) == false && UsedMonths.Contains(comboBoxMonth.Text + Convert.ToString(day)) == false)
                            {
                                buttons[day].Click += (sender, e) => { Day_Click(sender, e, day - 1); };
                                UsedYears.Add(textBoxYear.Text + Convert.ToString(day));
                                UsedMonths.Add(comboBoxMonth.Text + Convert.ToString(day));
                            }
                        }
                    }
                    break;
                case "Orange          ":
                    foreach (int busyday in BusyDaysDistinct)
                    {
                        int day = busyday;

                        if (day > 0)
                        {
                            buttons[day].BackColor = Color.Orange;
                            buttons[day].ForeColor = Color.Black;

                            if (UsedYears.Contains(textBoxYear.Text + Convert.ToString(day)) == false && UsedMonths.Contains(comboBoxMonth.Text + Convert.ToString(day)) == false)
                            {
                                buttons[day].Click += (sender, e) => { Day_Click(sender, e, day - 1); };
                                UsedYears.Add(textBoxYear.Text + Convert.ToString(day));
                                UsedMonths.Add(comboBoxMonth.Text + Convert.ToString(day));
                            }
                        }
                    }
                    break;
                case "Red          ":
                    foreach (int busyday in BusyDaysDistinct)
                    {
                        int day = busyday;

                        if (day > 0)
                        {
                            buttons[day].BackColor = Color.Red;
                            buttons[day].ForeColor = Color.Black;

                            if (UsedYears.Contains(textBoxYear.Text + Convert.ToString(day)) == false && UsedMonths.Contains(comboBoxMonth.Text + Convert.ToString(day)) == false)
                            {
                                buttons[day].Click += (sender, e) => { Day_Click(sender, e, day - 1); };
                                UsedYears.Add(textBoxYear.Text + Convert.ToString(day));
                                UsedMonths.Add(comboBoxMonth.Text + Convert.ToString(day));
                            }
                        }
                    }
                    break;
                case "Blue          ":
                    foreach (int busyday in BusyDaysDistinct)
                    {
                        int day = busyday;

                        if (day > 0)
                        {
                            buttons[day].BackColor = Color.Blue;
                            buttons[day].ForeColor = Color.Black;

                            if (UsedYears.Contains(textBoxYear.Text + Convert.ToString(day)) == false && UsedMonths.Contains(comboBoxMonth.Text + Convert.ToString(day)) == false)
                            {
                                buttons[day].Click += (sender, e) => { Day_Click(sender, e, day - 1); };
                                UsedYears.Add(textBoxYear.Text + Convert.ToString(day));
                                UsedMonths.Add(comboBoxMonth.Text + Convert.ToString(day));
                            }
                        }
                    }
                    break;
                case "Green          ":
                    foreach (int busyday in BusyDaysDistinct)
                    {
                        int day = busyday;

                        if (day > 0)
                        {
                            buttons[day].BackColor = Color.Green;
                            buttons[day].ForeColor = Color.Black;

                            if (UsedYears.Contains(textBoxYear.Text + Convert.ToString(day)) == false && UsedMonths.Contains(comboBoxMonth.Text + Convert.ToString(day)) == false)
                            {
                                buttons[day].Click += (sender, e) => { Day_Click(sender, e, day - 1); };
                                UsedYears.Add(textBoxYear.Text + Convert.ToString(day));
                                UsedMonths.Add(comboBoxMonth.Text + Convert.ToString(day));
                            }
                        }
                    }
                    break;
                case "Violet          ":
                    foreach (int busyday in BusyDaysDistinct)
                    {
                        int day = busyday;

                        if (day > 0)
                        {
                            buttons[day].BackColor = Color.Violet;
                            buttons[day].ForeColor = Color.Black;

                            if (UsedYears.Contains(textBoxYear.Text + Convert.ToString(day)) == false && UsedMonths.Contains(comboBoxMonth.Text + Convert.ToString(day)) == false)
                            {
                                buttons[day].Click += (sender, e) => { Day_Click(sender, e, day - 1); };
                                UsedYears.Add(textBoxYear.Text + Convert.ToString(day));
                                UsedMonths.Add(comboBoxMonth.Text + Convert.ToString(day));
                            }
                        }
                    }
                    break;
                case "Pink          ":
                    foreach (int busyday in BusyDaysDistinct)
                    {
                        int day = busyday;

                        if (day > 0)
                        {
                            buttons[day].BackColor = Color.Pink;
                            buttons[day].ForeColor = Color.Black;

                            if (UsedYears.Contains(textBoxYear.Text + Convert.ToString(day)) == false && UsedMonths.Contains(comboBoxMonth.Text + Convert.ToString(day)) == false)
                            {
                                buttons[day].Click += (sender, e) => { Day_Click(sender, e, day - 1); };
                                UsedYears.Add(textBoxYear.Text + Convert.ToString(day));
                                UsedMonths.Add(comboBoxMonth.Text + Convert.ToString(day));
                            }
                        }
                    }
                    break;
            } 
        }

        public void GenerateMonth()
        {
            /// GENERATES TODAYS DATE FOR MONTH AND YEAR
            DateTime TodayDate1 = DateTime.Now;

            int NowMonth = TodayDate1.Month;
            int NowYear = TodayDate1.Year;
            textBoxYear.Text = Convert.ToString(NowYear);

            comboBoxMonth.SelectedIndex = NowMonth - 1;
        }

        /// LISTS FOR TIMER
        List<string> Reminders = new List<string>();
        List<string> Sender = new List<string>();

        private void Timer_Tick(object sender, EventArgs e)
        {
            ///SHOWING CURRENT TIME
            Clock.Text = DateTime.Now.ToString("HH:mm:ss");

            /// REMINDER CHECK
            foreach (string reminder in Reminders)
            {
                if ((reminder + ":00") == DateTime.Now.ToString("HH:mm:ss"))
                {
                    NoteWindowMessageBox NoteMessage = new NoteWindowMessageBox();
                    NoteMessage.Text = "You set Reminder, check the notes!";
                    NoteMessage.Show();
                }
            }
            /// PLANNED MAIL CHECK
            foreach (string send in Sender)
            {
                if (send + ":00" == DateTime.Now.ToString("HH:mm:ss"))
                {
                    try
                    {
                        ///CONVERT FILE NAME INTO STRING WITH DATETIME
                        string[] sendSplit = send.Split(Convert.ToChar(":"));
                        string sendS = sendSplit[0] + sendSplit[1];
                        string firstDate = DateTime.Now.ToString("yyyy:MMMM:dd", CultureInfo.CreateSpecificCulture("en-US"));
                        string[] DateSplit = firstDate.Split(Convert.ToChar(":"));
                        string DateSplitS = DateSplit[0] + DateSplit[1] + DateSplit[2];

                        ///LOAD FILE WITH MAIL TO SEND

                        int LineCount = File.ReadAllLines(DateSplitS + sendS + ".smail").Length;
                        TextReader Load = new StreamReader(DateSplitS + sendS + ".smail");

                        Load.ReadLine();
                        Load.ReadLine();
                        Load.ReadLine();
                        Load.ReadLine();
                        Load.ReadLine();
                        Load.ReadLine();
                        string mail = Load.ReadLine();
                        string password = Load.ReadLine();
                        string Recipent = Load.ReadLine();
                        string Subject = Load.ReadLine();
                        List<string> Body = new List<string>();

                        for (int i = 0; i < (LineCount - 10); i++)
                        {
                            Body.Add(Load.ReadLine());
                        }

                        string MailBodySum = string.Join("\n", Body);

                        /// SENDING MAIL SCRIPT
                        var message = new MailMessage(mail, Recipent); /// email, recipent
                        message.Subject = Subject; /// email subject
                        message.Body = MailBodySum; /// email body

                        using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587)) /// loging to SMTP client
                        {
                            mailer.Credentials = new NetworkCredential(mail, password); /// email, password
                            mailer.EnableSsl = true;
                            mailer.Send(message);
                        }

                        Load.Close();

                        MailWindowMessageBox MailMessage = new MailWindowMessageBox();
                        MailMessage.Text = "Email was just send!";
                        MailMessage.Show();
                    }
                    catch (Exception Ex)
                    {
                        MailWindowMessageBox MailMessage = new MailWindowMessageBox();
                        MailMessage.Text = "Mail not Sended!";
                        MailMessage.Show();
                    }
                }
            }
        }
        

        /// BUTTONS SECTION

        /// BUTTON FOR CLICK ON DAY
        void Day_Click(object sender, EventArgs e, int day)
        {
            /// CREATES ARRAY OF FILES IN EXE DIRECTORY

            string[] Previewfiles = Directory.GetFiles(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            foreach (string file in Previewfiles)
            {
                /// START NOTES READING
                Match match = Regex.Match(file, @".mnote", RegexOptions.IgnoreCase);
                if (match.Success)
                {

                    int LineCount = File.ReadAllLines(file).Length;

                    TextReader Load = new StreamReader(file);

                    string Type = Load.ReadLine();

                    string Year = Load.ReadLine();

                    string Month = Load.ReadLine();

                    string Day = Load.ReadLine();

                    if (textBoxYear.Text == Year && comboBoxMonth.Text == Month && day == Convert.ToInt32(Day))
                    {
                        string Time = Load.ReadLine();

                        string Date = Year + "/" + Month + "/" + Day + " " + Time;
                        string Name = Load.ReadLine();
                        string Remind = Load.ReadLine();

                        List<string> Descriptions = new List<string>();

                        for (int i = 0; i < (LineCount - 7); i++)
                        {
                            Descriptions.Add(Load.ReadLine());
                        }

                        string sumDescription = string.Join("\n", Descriptions);
                        string Path = file;

                        ShowNoteWindow NoteWindow = new ShowNoteWindow();

                        NoteWindow.noteDate = Date;
                        NoteWindow.noteName = Name;
                        NoteWindow.noteDescription = sumDescription;
                        if (Remind == "1")
                        {
                            NoteWindow.noteReminder = "You set the Reminder!";
                        }
                        else
                        {
                            NoteWindow.noteReminder = "You didn't set the Reminder!";
                        }
                        NoteWindow.path = Path;

                        NoteWindow.Show();

                    }
                    Load.Close();
                }

                /// MAIL FILES READING 
                Match matchmail = Regex.Match(file, @".smail", RegexOptions.IgnoreCase);
                if (matchmail.Success)
                {
                    int LineCount = File.ReadAllLines(file).Length;
                    TextReader Load = new StreamReader(file);

                    string Type = Load.ReadLine();
                    string Year = Load.ReadLine();
                    string Month = Load.ReadLine();
                    string Day = Load.ReadLine();

                    if (textBoxYear.Text == Year && comboBoxMonth.Text == Month && day == Convert.ToInt32(Day))
                    {


                        string Date = Year + "/" + Month + "/" + Day;
                        string Time = Load.ReadLine();
                        string Sended = Load.ReadLine();
                        string MyMail = Load.ReadLine();
                        string MyPassword = Load.ReadLine();
                        string Recipent = Load.ReadLine();
                        string Subject = Load.ReadLine();

                        List<string> Body = new List<string>();

                        for (int i = 0; i < (LineCount - 10); i++)
                        {
                            Body.Add(Load.ReadLine());
                        }

                        string BodySum = string.Join("\n", Body); /// CREATE ONE STRING FROM MAIL BODY
                        string Path = file;

                        /// CREATE PRIEVIEW WITH EMAIL
                        ShowEmailWindow MailWindow = new ShowEmailWindow();
                        MailWindow.Date = Date + " " + Time;
                        MailWindow.Email = MyMail;
                        MailWindow.Receiver = Recipent;
                        MailWindow.Subject = Subject;
                        MailWindow.Body = BodySum;
                        /// CHECK IF MAIL WAS SENDED DIRECT
                        if (Sended == "yes")
                        {
                            MailWindow.Sended = "Mail Sended!";
                        }
                        else
                        {
                            foreach (string send in Sender)
                            {
                                if (Time != send)
                                {
                                    MailWindow.Sended = "Mail Sended!";
                                }
                            }
                        }
                        MailWindow.path = Path;

                        MailWindow.Show();

                    }
                    Load.Close();

                }
                /// READ EVENTS
                Match matchevent = Regex.Match(file, @".mevent", RegexOptions.IgnoreCase);
                if (matchevent.Success)
                {
                    int LineCount = File.ReadAllLines(file).Length;
                    TextReader Load = new StreamReader(file);

                    string Type = Load.ReadLine();
                    string Year = Load.ReadLine();
                    string Month = Load.ReadLine();
                    string Day = Load.ReadLine();

                    if (textBoxYear.Text == Year && comboBoxMonth.Text == Month && day == Convert.ToInt32(Day))
                    {

                        string Date = Year + "/" + Month + "/" + Day;
                        string Time = Load.ReadLine();
                        string End = Load.ReadLine();
                        string SMSReminder = Load.ReadLine();
                        string Name = Load.ReadLine();
                        string Location = Load.ReadLine();
                        string Description = Load.ReadLine();
                        string ID = textBoxYear.Text + comboBoxMonth.Text + Day;

                        string Path = file;

                        /// CREATE PREVIEW WITH EVENT
                        ShowEventWindow EventWindow = new ShowEventWindow();
                        EventWindow.name = ID;
                        EventWindow.Name = Name;
                        EventWindow.Location = Location;
                        EventWindow.Description = Description;
                        EventWindow.StartDate = Date + " " + Time;
                        EventWindow.EndDate = End;
                        /// CHECK FOR SMS REMINDER
                        if (SMSReminder == "yes")
                        {
                            EventWindow.SMS = "You set remind SMS!";
                        }
                        else
                        {
                            EventWindow.SMS = "No remind SMS!";
                        }

                        EventWindow.Show();
                    }
                    Load.Close();
                }
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// MAKING WINDOW MOVE WITH MOUSE CLICK
        Point lastPoint = new Point();

        private void panelCalendar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelCalendar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// LIMITS CHARS IN TEXT BOX TO 4 INTS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            textBoxYear.MaxLength = 4;
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadingColors();
            SetColor();
            generatecalendar();
        }

        private void buttonPrevMonth_Click(object sender, EventArgs e)
        {
            /// SELECT PREV MONTH
            if (comboBoxMonth.SelectedIndex > 0)
            {
                comboBoxMonth.SelectedIndex = comboBoxMonth.SelectedIndex - 1;
            }
            LoadingColors();
            SetColor();
            generatecalendar();
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            /// SELECT NEXT MONTH
            if (comboBoxMonth.SelectedIndex < comboBoxMonth.Items.Count - 1)
            {
                comboBoxMonth.SelectedIndex = comboBoxMonth.SelectedIndex + 1;
            }
            LoadingColors();
            SetColor();
            generatecalendar();
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            if (addNote1.Visible == false)
            {
                addNote1.Show();
                addEmail1.Hide();
                addEvent1.Hide();
                setting1.Hide();
            }
            else
            {
                addNote1.Hide();
                addEmail1.Hide();
                addEvent1.Hide();
                setting1.Hide();
            }
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {
            if (addEmail1.Visible == false)
            {
                addEmail1.Show();
                addNote1.Hide();
                addEvent1.Hide();
                setting1.Hide();
            }
            else
            {
                addNote1.Hide();
                addEmail1.Hide();
                addEvent1.Hide();
                setting1.Hide();
            }
        }
        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            if (addEvent1.Visible == false)
            {
                addEvent1.Show();
                addNote1.Hide();
                addEmail1.Hide();
                setting1.Hide();
            }
            else
            {
                addNote1.Hide();
                addEmail1.Hide();
                addEvent1.Hide();
                setting1.Hide();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (setting1.Visible == false)
            {
                setting1.Show();
                addNote1.Hide();
                addEmail1.Hide();
                addEvent1.Hide();
            }
            else
            {
                addNote1.Hide();
                addEmail1.Hide();
                addEvent1.Hide();
                setting1.Hide();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool FormsHidden = false;

        List<Form> FormsCollection = new List<Form>();

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FormsHidden == false)
            {
                foreach(Form frm in Application.OpenForms)
                {
                    frm.Hide();
                    FormsCollection.Add(frm);
                }
                hideToolStripMenuItem.Text = "Show";
                FormsHidden = true;
            }
            else
            {
                this.Show();
                foreach(Form frm in FormsCollection)
                {
                    frm.Show();
                }
                FormsCollection.Clear();
                hideToolStripMenuItem.Text = "Hide";
                FormsHidden = false;
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

