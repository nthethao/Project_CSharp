using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


  public  class TimerThread
    {
        private string state;
        public TimerThread(string state)
        {
            this.state = state;
        }
        static AutoResetEvent autoEvent = new AutoResetEvent(false);
        public void WriteLog(object message)
        {
           
            try
            {
                Console.WriteLine(DateTime.Now.ToString() + message);
            }
            catch
            {
            }
        }
        /// <summary>
        /// thực hiện vòng lặp thread 10s một lần
        /// </summary>
        /// <param name="state"></param>
        public void ThreadTimer()
        {
            WriteLog("Log Test Begin");
            TimerCallback handler = new TimerCallback(WriteLog);
            using (var timer = new Timer(handler, state, 0, 1000))
            {
                while (!autoEvent.WaitOne(1000))
                {
                    autoEvent.Set();
                }
            };
        }
    }

