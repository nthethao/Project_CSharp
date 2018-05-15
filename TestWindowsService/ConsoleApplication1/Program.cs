using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        private AutoResetEvent AutoEventInstance { get; set; }
        private StatusChecker StatusCheckerInstance { get; set; }
        private Timer StateTimer { get; set; }


        static void Main(string[] args)
        {
            // int TimerInterval = 10000;
            // AutoResetEvent AutoEventInstance = new AutoResetEvent(false);
            // StatusChecker StatusCheckerInstance = new StatusChecker();
            // TimerCallback timerDelegate =
            //     new TimerCallback(StatusCheckerInstance.CheckStatus);

            // Console.WriteLine("{0} Creating timer.\n",
            //DateTime.Now.ToString("h:mm:ss.fff"));
            // Timer StateTimer = new Timer(timerDelegate, AutoEventInstance, 0, Timeout.Infinite);
            // while (StateTimer != null)
            // {
            //     //Wait until the job is done
            //     AutoEventInstance.WaitOne();
            //     //Wait for 5 minutes before starting the job again.
            //     StateTimer.Change(TimerInterval, Timeout.Infinite);
            // }


            WriteEventLogEntry("This is an entry in the event log by daveoncsharp.com");
        }

        private static void WriteEventLogEntry(string message)
        {
            // Create an instance of EventLog
            System.Diagnostics.EventLog eventLog = new System.Diagnostics.EventLog();

            // Check if the event source exists. If not create it.
            if (!System.Diagnostics.EventLog.SourceExists("TestApplication"))
            {
                System.Diagnostics.EventLog.CreateEventSource("TestApplication", "Application");
            }

            // Set the source name for writing log entries.
            eventLog.Source = "TestApplication";

            // Create an event ID to add to the event log
            int eventID = 124;

            // Write an entry to the event log.
            eventLog.WriteEntry(message,
                                System.Diagnostics.EventLogEntryType.Error,
                                eventID);

            // Close the Event Log
            eventLog.Close();
        }




    }

    class StatusChecker
    {
        public StatusChecker()
        {
        }

        // This method is called by the timer delegate.
        public void CheckStatus(Object stateInfo)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;
            Console.WriteLine("{0} doing .\n",
            DateTime.Now.ToString("h:mm:ss.fff"));
            autoEvent.Set();
        }


    }
}
