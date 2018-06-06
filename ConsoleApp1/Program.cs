//using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleThreadExample simpleThread = new SimpleThreadExample();
            //simpleThread.StartMultipleThread();

            //AutoResetEventExample autoResetEventExample = new AutoResetEventExample();
            //autoResetEventExample.StartThread();

            ThreadPoolExample threadPoolExample = new ThreadPoolExample();
            threadPoolExample.ThreadStart();
        }
    }


}




