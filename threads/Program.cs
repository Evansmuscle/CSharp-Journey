using System.Globalization;
using System;
using System.Threading;

namespace threads
{
    class Program
    {
        public static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;

            Thread threadOne = new Thread(() => CountUp(0, 10));
            Thread threadTwo = new Thread(() => CountDown(10, 0));

            threadOne.Start();
            threadTwo.Start();
        }

        public static void CountUp(int countFrom, int countTo)
        {
            for (int i = countFrom; i < (countTo + 1); i++)
            {
                Console.WriteLine($"Current number: {i}");
                Thread.Sleep(1000);
            }
        }

        public static void CountDown(int countFrom, int countTo)
        {
            for (int i = countFrom; i > (countTo - 1); i--)
            {
                Console.WriteLine($"Current number: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
