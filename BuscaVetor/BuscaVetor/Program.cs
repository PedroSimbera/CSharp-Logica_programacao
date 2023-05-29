using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] Q = new int[20];     
            for (int i = 0; i <= 19; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " valor: ");

                Q[i] = Convert.ToInt32(Console.ReadLine());

                if (Q[i] < 0)

                {
                    Console.WriteLine("Negativo, digite novamente");

                    Console.WriteLine();
                    i--;
                }
            }

            int maior = Q[0];          
            for (int i = 0; i <= 19; i++)
            {
                if (Q[i] > maior)
                {
                    maior = Q[i];
                }
            }

            Console.WriteLine("Maior valor: " + maior);

            int pos = Array.IndexOf(Q, maior);

            if (pos == -1)
            {
                Console.WriteLine("O elemento não foi encontrado no vetor.");
            }
            else
            {
                Console.WriteLine("O elemento está na posição: " + (pos + 1));
                Console.WriteLine("Lembre-se que as posições começam no 0 e vão até 19 - sendo 20 elementos");
            }
                       
            Console.ReadKey();
        }
    }
}
