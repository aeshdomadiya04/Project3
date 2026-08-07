using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class clock
    {
        private int hour;
        private int min;
        private int sec;

        //no argument constructor
        public clock()
        {
            hour = 12;
            min = 0;
            sec = 0;

        }

        //parameterized constructor
        public clock(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }

        public void IncrementTime()
        {
            sec++;

            if (sec == 60)
            {
                sec = 0;
                min++;

                if (min == 60)
                {
                    min = 0;
                    hour++;

                    if (hour == 24)
                        hour = 0;

                }
            }
        }

        public void Display()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", hour, min, sec);
        }

        public int GetHour()
        {
            return hour;
        }

        public int GetMinutes()
        {
            return min;
        }

        public int GetSecond()
        {
            return sec;
        }
    }


    class Program2
    {
        static void Main()
        {
            clock c = new clock();

            Console.WriteLine("Current Time:");
            c.Display();

            c.IncrementTime();

            Console.WriteLine("After increment:");
            c.Display();

            Console.Read();
        }
    }
}
