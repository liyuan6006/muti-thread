using System;
using System.Threading;

public class DestroyThreadExample
{
    public bool IsCancelled { get; set; }

    public Thread MyThread { get; set; }

    public void StartThread()
    {
        MyThread = new Thread(() =>
        {
            int numberOfSeconds = 0;
            while (numberOfSeconds < 8)
            {
                if (IsCancelled == false)
                {
                    break;
                }

                Thread.Sleep(1000);

                numberOfSeconds++;
            }

            Console.WriteLine("I ran for {0} seconds", numberOfSeconds);
        });
    }

    //Destroy thread
    public void Abort()
    {
        MyThread.Abort();
    }

    //Graceful exit
    public void GracefulAbort()
    {
        IsCancelled = true;
    }
}
