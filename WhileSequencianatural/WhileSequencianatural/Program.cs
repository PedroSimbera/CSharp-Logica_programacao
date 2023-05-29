using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSequencianatural
{
    internal class Program
    {
        static void Main(string[] args)
        {//início
            Console.WriteLine("Indique o primeiro número para a sequência de naturais: ");
            int I = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique o segundo número para a sequência de naturais: ");
            int F = Convert.ToInt32(Console.ReadLine());
            
            while (I<=F)
            {
                Console.Write(I);
                I += 1;
            }

            Console.ReadKey();
        }//fim
    }
}
