using System;
using System.Collections.Generic;
using System.Text;

namespace zadacha1_Nikol
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }

        public Time(int hour, int minute, int second)
        {
            if (hour < 0 || minute < 0 || second < 0)
            {
                throw new ArgumentException("Часът, минутите и секундите не могат да бъдат отрицателни.");
            }

            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void PrintTime()
        {
            Console.WriteLine($"{hour:D2}:{minute:D2}:{second:D2}");
        }
    }
}