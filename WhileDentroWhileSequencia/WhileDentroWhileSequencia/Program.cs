using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDentroWhileSequencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n;

            while (i <= 10)
            {
                Console.Write(i + ", ");

                n = 1; 

                while (n <= 10)
                {
                    Console.Write(n + " ");
                    n++;
                }

                Console.WriteLine(); 
                i++;
            }

            Console.ReadKey();
        }
    }
}
