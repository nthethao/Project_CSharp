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

        private Thread threadWriteLog = new Thread(ThreadTimer);
        static AutoResetEvent autoEvent = new AutoResetEvent(true);

        public Service1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// viết file log
        /// </summary>
        /// <param name="message"></param>
        private static void WriteLog(object message)
        {
            try
            {
                StreamWriter strWrite = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Log.txt", true);
                strWrite.WriteLine(DateTime.Now.ToString() + ": " + message + "\n");
                strWrite.Flush();
                strWrite.Close();
            }
            catch
            {
            }
        }
        /// <summary>
        /// thực hiện vòng lặp thread 10s một lần
        /// </summary>
        /// <param name="state"></param>
        private static void ThreadTimer(object state)
        {
            WriteLog("Log Test Begin");
            TimerCallback handler = new TimerCallback(WriteLog);
            using (var timer = new Timer(handler, state, 0, 10000))
            {
                while (autoEvent.WaitOne(10000))
                {
                    autoEvent.Set();
                }
            };
        }

        /// <summary>
        /// thực hiện evenlog
        /// </summary>
        /// <param name="message"></param>
        private  void WriteEvenLog(string message)
        {
            EventLog eventLog = new EventLog();
            eventLog.Source = "Service_1";
            eventLog.Log = "Application";
            int eventID = 123;
            if (!EventLog.SourceExists(eventLog.Source))
            {
                EventLog.CreateEventSource(eventLog.Source, eventLog.Log);
            }
            else
            {
                EventLog.WriteEntry(eventLog.Source, message, EventLogEntryType.Information, eventID);
            }
        }


        protected override void OnStart(string[] args)
        {
            threadWriteLog.Start("Log Test Doing");
            WriteEvenLog("Evenlog Test Begin");
        }

        protected override void OnStop()
        {
            WriteLog("Log Test Stop");
            threadWriteLog.Abort();
            WriteEvenLog("Evenlog Test Stop");
        }
    }
}
