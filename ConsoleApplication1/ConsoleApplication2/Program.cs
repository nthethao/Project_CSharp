using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // timers.
            Program ex = new Program();
            ex.StartTimer(2000);
            ex.StartTimer(1000);

            Console.WriteLine("Press Enter to end the program.");
            Console.ReadLine();
        }
        public void StartTimer(int dueTime)
        {
            Timer t = new Timer(new TimerCallback(TimerProc));
            t.Change(dueTime, 0);
        }

        private void TimerProc(object state)
        {
            // The state object is the Timer object.
            Timer t = (Timer)state;
            t.Dispose();
            Console.WriteLine("The timer callback executes.");
        }
    }
}
