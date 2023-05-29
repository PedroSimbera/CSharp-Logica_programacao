using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLeituraNegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {//início
           int num=0;
            do
            {
                Console.WriteLine("Digite um número: ");
                num = Convert.ToInt32(Console.ReadLine());

            }
            while (num >= 1); 

            Console.ReadKey();

        }//fim
    }
}
