using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeeCrowd1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            float x1, y1, x2, y2;
            double distancia;
            
            string[] p1 = Console.ReadLine().Split(' ');
            x1 = float.Parse(p1[0]);
            y1 = float.Parse(p1[1]);

            string[] p2 = Console.ReadLine().Split(' ');
            x2 = float.Parse(p2[0]);
            y2 = float.Parse(p2[1]);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}
