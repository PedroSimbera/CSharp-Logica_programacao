using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
        INICIO:
            Console.WriteLine("Digite dois números: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            double troca;
            double soma = 0;

            if (num1 > num2)
            {
                troca = num1;
                num1 = num2;
                num2 = troca;
            }
            for (double i = num1 + 1; i < num2; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine("A soma dos números ímpares no intervalo de ambos números digitados é: " + soma);


            Console.ReadKey();
            Console.Clear();
            goto INICIO;
        }
    }
}
