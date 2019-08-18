using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalendar
{
    class Preview
    {
        public int ID { get; set; }
        string Type;
        int day;
        string Day;
        string Date;
        string Time;
        string Name;
        string Reminder;
        string Description;

        string Sended;
        string MyMail;
        string MyPassword;
        string Recipent;
        string Subject;
        string Body;

        string EventID;
        string EndDate;
        string SMSReminder;
        string Location;

        string Path;

        public void SetNoteData(int conID, string conType, int conday, string conDay, string conDate, string conTime, string conName, string conReminder, string conDescription, string conPath)
        {
            ID = conID;
            Type = conType;
            day = conday;
            Day = conDay;
            Date = conDate;
            Time = conTime;
            Name = conName;
            Reminder = conReminder;
            Description = conDescription;
        }

        public void SetEmailData(int conID, string conType, int conday, string conDay, string conDate, string conTime, string conSended, string conMyMail, string conMyPassword, string conRecipent, string conSubject, string conBody, string conPath)
        {
            ID = conID;
            Type = conType;
            day = conday;
            Day = conDay;
            Date = conDate;
            Time = conTime;
            Sended = conSended;
            MyMail = conMyMail;
            MyPassword = conMyPassword;
            Recipent = conRecipent;
            Subject = conSubject;
            Body = conBody;
            Path = conPath;

        }

        public void SetEventData(int conID, string conType, int conday, string conDay, string conDate, string conTime, string conEnd, string conSMSReminer, string conName, string conLocation, string conDescription, string conEventID, string conPath)
        {
            ID = conID;
            Type = conType;
            day = conday;
            Day = conDay;
            Date = conDate;
            Time = conTime;
            EndDate = conEnd;
            SMSReminder = conSMSReminer;
            Name = conName;
            Location = conLocation;
            Description = conDescription;
            EventID = conEventID;
            Path = conPath;
        }
        public int GetID()
        {
            return ID;
        }
        public string GetType()
        {
            return Type;
        }
        public int Getday()
        {
            return day;
        }
        public string GetDay()
        {
            return Day;
        }
        public string GetDate()
        {
            return Date;
        }
        public string GetTime()
        {
            return Time;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetReminder()
        {
            return Reminder;
        }
        public string GetDescription()
        {
            return Description;
        }

        public string GetSended()
        {
            return Sended;
        }
        public string GetMyMail()
        {
            return MyMail;
        }
        public string GetMyPassword()
        {
            return MyPassword;
        }
        public string GetRecipent()
        {
            return Recipent;
        }
        public string GetSubject()
        {
            return Subject;
        }
        public string GetBody()
        {
            return Body;
        }

        public string GetEndDate()
        {
            return EndDate;
        }
        public string GetSMSReminder()
        {
            return SMSReminder;
        }
        public string GetLocation()
        {
            return Location;
        }
        public string GetEventID()
        {
            return EventID;
        }

        public string GetPath()
        {
            return Path;
        }
    }
}
