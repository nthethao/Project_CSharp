using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

public class ConsoleApplication1
{


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
    public static void ThreadTimer( )
    {
        TimerCallback handler = new TimerCallback(WriteLog);
        string state = "Log Begin!!!";

        using (var timer = new Timer(handler, state, 0, 3000)) {
            while (true) { 
            }
        };


    }
    private static void WriteEvenLog(string message) {
        //create regitri to fix The source was not found, but some or all event logs could not be searched. Inaccessible logs: Security 
        EventLog eventlog = new EventLog();
        eventlog.Source = "TestWindowLog";
        eventlog.Log = "Application";
        int eventID = 123;
        if (!EventLog.SourceExists(eventlog.Source))
        {
            EventLog.CreateEventSource(eventlog.Source,eventlog.Log);
        }
        else{
            EventLog.WriteEntry(eventlog.Source,message,EventLogEntryType.Information,eventID);
        }
    }



    public static void Main()
    {
        Thread thread1 = new Thread(ThreadTimer);
        thread1.Start();
        WriteEvenLog("Evenlog Test begin");
        
    }
}