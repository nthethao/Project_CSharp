using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//using System.Timers;
using TestWindowsService;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    #region Timer
    //{
    //    private Timer timer1 = null;
    //    public Service1()
    //    {
    //        InitializeComponent();
    //    }

    //    protected override void OnStart(string[] args)
    //    {
    //        timer1 = new Timer();
    //        this.timer1.Interval = 5000;
    //        this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
    //        timer1.Enabled = true;
    //        Library.WriteErrorLog("test started \n");

    //    }
    //    private void timer1_Tick(object sender, ElapsedEventArgs e) {
    //        Library.WriteErrorLog("timer successfully \n");
    //    }

    //    protected override void OnStop()
    //    {
    //        timer1.Enabled = false;
    //        Library.WriteErrorLog("test stop \n");
    //    }
    //}

    #endregion


    {
        private AutoResetEvent AutoEventInstance { get; set; }
        private StatusChecker StatusCheckerInstance { get; set; }
        private Timer StateTimer { get; set; }
        public int TimerInterval { get; set; }

        public Service1()
        {
            InitializeComponent();
            TimerInterval = 10000;
        }

        protected override void OnStart(string[] args)
        {
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
            Library.WriteErrorLog("test start \n");
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

        protected override void OnStop()
        {
            Library.WriteErrorLog("test stop \n");
            StateTimer.Dispose();
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
            Library.WriteErrorLog("doing \n");
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
