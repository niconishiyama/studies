using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeeCrowd1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            double triangulo, circulo, trapezio, quadrado, retangulo, pi;

            string[] values = Console.ReadLine().Split(' ');
                double A = double.Parse(values[0]);
                double B = double.Parse(values[1]);
                double C = double.Parse(values[2]);

            pi = 3.14159;
            triangulo = A * C / 2.0;
            circulo = pi * Math.Pow(C, 2.0);
            trapezio = (A + B) * C / 2.0;
            quadrado = Math.Pow(B, 2.0);
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: {0}", retangulo.ToString("F3"));
        }
    }
}
