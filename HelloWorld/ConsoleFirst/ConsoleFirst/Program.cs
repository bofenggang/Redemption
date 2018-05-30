using System;
using FluentScheduler;

namespace FluentSchedulerConsoleFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            JobManager.AddJob(() =>
            {
                Console.WriteLine("Timer task,current time:{0}", DateTime.Now);
            }, t =>
            {
                //每2秒
                t.ToRunNow().AndEvery(2).Seconds();
            });
            Console.ReadKey();
        }
    }
}
