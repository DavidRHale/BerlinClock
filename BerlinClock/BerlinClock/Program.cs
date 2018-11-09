using System;
using System.Collections.Generic;

namespace BerlinClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class BerlinClock
    {
        public int SendOne()
        {
            return 1;
        }

        public string CalculateSingleMinuteRow(string standardTime)
        {
            var minstr = standardTime.Substring(3, 2);
            var minutes = Int32.Parse(minstr);

            var numOfLightsOn = minutes % 5;

            var berlinTime = "";

            for (int i = 1; i < 5; i++)
            {
                if (i <= numOfLightsOn)
                {
                    berlinTime += "Y";
                }
                else
                {
                    berlinTime += "O";
                }
            }

           return berlinTime;
        }

        public string CalculateFiveMinuteRow(string standardTime)
        {
            return "OOOOOOOOOOO";
        }
    }
}
