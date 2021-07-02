using System;
using System.Threading;

namespace helloWorld
{
    class multiThreading
    {
        public void multiThreadingExamples()
        {
            Console.WriteLine("*****MultiThread*****");
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";

            Console.WriteLine("This is {0}", th.Name);
            Console.ReadKey();
        }
    }
}
