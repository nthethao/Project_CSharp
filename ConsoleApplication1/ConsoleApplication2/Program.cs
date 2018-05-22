using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

    class Program
    {
        private static AutoResetEvent event_1 = new AutoResetEvent(false);
        private static AutoResetEvent event_2 = new AutoResetEvent(false);

        static void Main()
        {
            Console.WriteLine("Press Enter to create three threads and start them.\r\n");
          

        
                Thread t = new Thread(ThreadProc);
                t.Start();
            Thread.Sleep(1050);

         
                Console.WriteLine("1");
                event_1.Set();
                Thread.Sleep(2050);
          
                Console.WriteLine("2");
               
                event_2.Set();
                Thread.Sleep(3050);
                Console.Read();
            }

            // Visual Studio: Uncomment the following line.
            //Console.Readline();
        

        static void ThreadProc()
        {
            

            Console.WriteLine("a");
            event_1.WaitOne();
            Console.WriteLine("b");

            Console.WriteLine("c");
            event_2.WaitOne();
            Console.WriteLine("d");
        }
}  

