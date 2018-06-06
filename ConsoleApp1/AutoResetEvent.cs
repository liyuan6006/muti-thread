using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class AutoResetEventExample
    {
        static AutoResetEvent autoEvent;

        static void DoWork()
        {
            Console.WriteLine("   worker thread started, now waiting on event...");
            autoEvent.WaitOne();
            Console.WriteLine("   worker thread reactivated, now exiting...");
        }

        public void StartThread()
        {
            autoEvent = new AutoResetEvent(false);
            Console.WriteLine("main thread starting worker thread...");
            Thread t = new Thread(DoWork);
            t.Start();

            Console.WriteLine("main thread sleeping for 1 second...");
            Thread.Sleep(1000);

            Console.WriteLine("main thread signaling worker thread...");
            autoEvent.Set();
        }

    }
}
