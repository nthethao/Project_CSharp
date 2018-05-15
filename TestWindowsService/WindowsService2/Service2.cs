using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsService2
{
    public partial class Service2 : ServiceBase
    {

        private AutoResetEvent AutoEventInstance { get; set; }
        private StatusChecker StatusCheckerInstance { get; set; }
        private Timer StateTimer { get; set; }
        public int TimerInterval { get; set; }

        public Service2()
        {
            InitializeComponent();
            TimerInterval = 10000;
        }

        protected override void OnStart(string[] args)
        {
            try
            {

                WriteEventLogEntry("WindowsService2 begin");

                AutoEventInstance = new AutoResetEvent(false);
                StatusCheckerInstance = new StatusChecker();

                // Create the delegate that invokes methods for the timer.
                TimerCallback timerDelegate =
                    new TimerCallback(StatusCheckerInstance.CheckStatus);

                // Create a timer that signals the delegate to invoke 
                // 1.CheckStatus immediately, 
                // 2.Wait until the job is finished,
                // 3.then wait 5 minutes before executing again. 
                //// 4.Repeat from point 2.
                //Console.WriteLine("{0} Creating timer.\n",
                //    DateTime.Now.ToString("h:mm:ss.fff"));
                Library.WriteErrorLog("Service Start 1 !!! \n");
                //Start Immediately but don't run again.
                StateTimer = new Timer(timerDelegate, AutoEventInstance, 0, Timeout.Infinite);
                while (StateTimer != null)
                {
                    //Wait until the job is done
                    AutoEventInstance.WaitOne();
                    //Wait for 5 minutes before starting the job again.
                    StateTimer.Change(TimerInterval, Timeout.Infinite);
                }
                //If the Job somehow takes longer than 5 minutes to complete then it wont matter because we will always wait another 5 minutes before running again.
            }
            catch (Exception ex) {
                EventLog.WriteEntry("Application", ex.ToString(), EventLogEntryType.Error);
            }
           
           
           }

        protected override void OnStop()
        {
            WriteEventLogEntry("WindowsService2 Stop");
            Library.WriteErrorLog("Service Stop !!! \n");
            StateTimer.Dispose();
        }

        private static void WriteEventLogEntry(string message)
        {
            // Create an instance of EventLog
            System.Diagnostics.EventLog eventLog = new System.Diagnostics.EventLog();

            // Check if the event source exists. If not create it.
            if (!System.Diagnostics.EventLog.SourceExists("Service2"))
            {
                System.Diagnostics.EventLog.CreateEventSource("Service2", "Application");
            }

            // Set the source name for writing log entries.
            eventLog.Source = "Service2";

            // Create an event ID to add to the event log
            int eventID = 123;

            // Write an entry to the event log.
            eventLog.WriteEntry(message,
                                System.Diagnostics.EventLogEntryType.Information,
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
            //Console.WriteLine("{0} Start Checking status.",
            //    DateTime.Now.ToString("h:mm:ss.fff"));
            Library.WriteErrorLog("Doing !!! \n");
            //This job takes time to run. For example purposes, I put a delay in here.
            //int milliseconds = 5000;
            //Thread.Sleep(milliseconds);
            ////Job is now done running and the timer can now be reset to wait for the next interval
            //Console.WriteLine("{0} Done Checking status.",
            //    DateTime.Now.ToString("h:mm:ss.fff"));
            autoEvent.Set();
        }


    }

}
