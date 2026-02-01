using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class clsGlobal
    {
        public static clsUser CurrentUser;

        public static void LoggingAllExepctions(string message, EventLogEntryType type)
        {
            clsLogger.LoggingAllExepctions(message, type);
        }
    }
}
