using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_de_tres
{
    internal class Program
    {
        static void Main(string[] args)
        {
        INICIO:
            Console.WriteLine("Qual o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o terceiro número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if ((num1 <= num2) && (num1 <= num3))
            {
                Console.WriteLine("Primeiro número é menor: " + num1);
            }
            else if ((num2 <= num3) && (num2 <= num1))
            {
                Console.WriteLine("Segundo número é menor: " + num2);
            }
            else
            {
                Console.WriteLine("Terceiro número é menor: " + num3);
            }
            Console.ReadKey();
            Console.Clear();
            goto INICIO;
        }
    }
}
