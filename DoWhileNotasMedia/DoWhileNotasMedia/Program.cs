using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileNotasMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {//início
            int num;
            do
            {
                Console.Write("Digite um número par: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Você digitou o número par: " + num);
            } 
            while (num % 2 == 0);

            
            Console.ReadKey();


        }//fim
    }
}
