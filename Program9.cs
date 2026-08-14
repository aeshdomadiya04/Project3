using System;

namespace Lab3
{                                   
    class Clock
    {
        private int hour;
        private int minute;
        private int second;

        // Default Constructor
        public Clock()
        {
            hour = 12;
            minute = 0;
            second = 0;
        }

        // Parameterized Constructor
        public Clock(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public void Increment()
        {
            second++;

            if (second == 60)
            {
                second = 0;
                minute++;

                if (minute == 60)
                {
                    minute = 0;
                    hour++;

                    if (hour == 24)
                        hour = 0;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Time : {0:D2}:{1:D2}:{2:D2}", hour, minute, second);
        }
    }

    internal class Program9
    {
        static void Main()
        {
            Clock c = new Clock(10, 59, 59);

            Console.WriteLine("Current Time");
            c.Display();

            c.Increment();

            Console.WriteLine("After Increment");
            c.Display();

            Console.Read();
        }
    }
}