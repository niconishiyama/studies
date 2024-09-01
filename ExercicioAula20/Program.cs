using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicioAula20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double largura, comprimento, valorMetroQuadrado, area, preco;

            Console.Write("Digite a Largura: ");
            largura = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do metro quadrado: ");
            valorMetroQuadrado = double.Parse(Console.ReadLine());

            area = largura * comprimento;
            preco = valorMetroQuadrado * area;

            Console.WriteLine("AREA = {0}", area.ToString("F2"));
            Console.WriteLine("PRECO = {0}", preco.ToString("F2"));
        }
    }
}
