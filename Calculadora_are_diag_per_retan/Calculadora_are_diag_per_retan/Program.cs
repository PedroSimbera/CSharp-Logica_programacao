using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_are_diag_per_retan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bas, altura, area, perimetro, diagonal;
            Console.WriteLine("Qual o valor da base do retangulo: ");
            bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o valor da altura do retangulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            area = bas * altura;
            perimetro = (bas * 2) + (altura * 2);
            diagonal = Math.Sqrt((bas * bas) + (altura * altura));

            Console.WriteLine("A area é: " + area + ". O perimetro é: " + perimetro + ". A diagonal é: " + diagonal);
            Console.ReadKey();
        }
    }
}
