using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HMS_DataAccess
{
    public class clsLogger
    {
        public static void LoggingAllExepctions(string message, EventLogEntryType type)
        {
            string nameOfProgram = "HotelManagementSystem";
            if (!EventLog.SourceExists(nameOfProgram))
            {
                EventLog.CreateEventSource(nameOfProgram, "Application");
            }

            EventLog.WriteEntry(nameOfProgram, message, type);
        }
    }
}
