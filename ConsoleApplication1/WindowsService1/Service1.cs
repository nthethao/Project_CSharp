using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        private static void WriteLog(object message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Log.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + message + "\n");
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }
        public static void ThreadTimer()
        {
            TimerCallback handler = new TimerCallback(WriteLog);
            string state = "Log Begin!!!";

            using (var timer = new Timer(handler, state, 0, 10000))
            {
                while (true)
                {
                }
            };


        }
        private static void WriteEvenLog(string message)
        {
            EventLog eventlog = new EventLog();
            eventlog.Source = "TestWindowLog";
            eventlog.Log = "Application";
            int eventID = 123;
            if (!EventLog.SourceExists(eventlog.Source))
            {
                EventLog.CreateEventSource(eventlog.Source, eventlog.Log);
            }
            else
            {
                EventLog.WriteEntry(eventlog.Source, message, EventLogEntryType.Information, eventID);
            }
        }



        private Thread thread1 = new Thread(ThreadTimer);
        protected override void OnStart(string[] args)
        {
            WriteLog("Log Test Begin");
            thread1.Start();
            WriteEvenLog("Evenlog Test Begin");
        }

        protected override void OnStop()
        {
            WriteLog("Log Test Stop");
            thread1.Abort();
            WriteEvenLog("Evenlog Test Stop");
        }
    }
}
