using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoav_Faran_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondsTotal = Convert.ToInt32(Console.ReadLine());
            if (secondsTotal < 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                int days = 0;
                int hours = 0;
                int minutes = 0;
                int seconds = 0;
                days = secondsTotal / 86400;
                secondsTotal = secondsTotal % 86400;
                hours = secondsTotal / 3600;
                secondsTotal = secondsTotal % 3600;
                minutes = secondsTotal / 60;
                secondsTotal = secondsTotal % 60;
                seconds = secondsTotal;
                Console.WriteLine($"{days} days");
                Console.WriteLine($"{hours} hours");
                Console.WriteLine($"{minutes} minutes");
                Console.WriteLine($"{seconds} seconds");
            }
        }
    }
}
