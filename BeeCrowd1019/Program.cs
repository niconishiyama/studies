using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeCrowd1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours, minutes, seconds, time;

            time = int.Parse(Console.ReadLine());

            seconds = time % 60;
            minutes = time / 60 % 60;
            hours = time / 3600;

            Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
        }
    }
}
