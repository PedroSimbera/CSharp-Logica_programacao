using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileMaioridade
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio
           
            int i = 0; 
            int n = 1; 
            while (n <= 10)
            {
                Console.WriteLine("Digite a idade da pessoa " + n + ":");
                int idade = Convert.ToInt32(Console.ReadLine());

                if (idade > 18)
                {
                    i++;
                }

                n++;
            }

            Console.WriteLine("Existem " + i + " pessoas com mais de 18 anos.");

            Console.ReadKey();
        }//fim
    }

}
  

