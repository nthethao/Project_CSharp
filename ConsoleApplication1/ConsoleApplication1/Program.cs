using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

public class ConsoleApplication1
{

    static ManualResetEvent autoEvent = new ManualResetEvent(false);

    private void WriteLog(object message)
    {
        try
        {
            //StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Log.txt", true);
            //sw.WriteLine(DateTime.Now.ToString() + ": " + message + "\n");
            //sw.Flush();
            //sw.Close();
            Console.WriteLine(DateTime.Now.ToString() + ":  " + message);
        }
        catch
        {
        }
    }
    public void ThreadTimer()
    {
        WriteLog("Evenlog Test begin");
        //TimerCallback handler = new TimerCallback(WriteLog);

        //var timer = new Timer(handler, state, 0, 1000);

        while (!autoEvent.WaitOne(1000))
        {

     //       autoEvent.Set();
            WriteLog("Evenlog Test Doing ");

        }



        WriteLog("Evenlog Test Stop");



    }
    // WriteEvenLog

    //private static void WriteEvenLog(string message) {
    //    //create regitri to fix The source was not found, but some or all event logs could not be searched. Inaccessible logs: Security 
    //    EventLog eventlog = new EventLog();
    //    eventlog.Source = "TestWindowLog";
    //    eventlog.Log = "Application";
    //    int eventID = 123;
    //    if (!EventLog.SourceExists(eventlog.Source))
    //    {
    //        EventLog.CreateEventSource(eventlog.Source,eventlog.Log);
    //    }
    //    else{
    //        EventLog.WriteEntry(eventlog.Source,message,EventLogEntryType.Information,eventID);
    //    }
    //}



    public static void Main()
    {
        ConsoleApplication1 class1 = new ConsoleApplication1();
        Thread thread1 = new Thread(class1.ThreadTimer);
        thread1.Start();
        //      WriteEvenLog("Evenlog Test begin");
        Console.Read();

    }
}