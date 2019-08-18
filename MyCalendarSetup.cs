using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace MyCalendar
{
    [RunInstaller(true)]
    public partial class MyCalendarSetup : System.Configuration.Install.Installer
    {
        public MyCalendarSetup()
        {
            InitializeComponent();
        }
    }
}
