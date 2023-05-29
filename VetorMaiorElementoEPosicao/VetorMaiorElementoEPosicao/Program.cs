using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorMaiorElementoEPosicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = new string[10];
            string nomeBusca;

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "nome da lista: ");
                nomes[i] = Console.ReadLine();
            }
            
            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = nomes[i].Trim();
                nomes[i] = nomes[i].ToLower();
            }


            Console.WriteLine("Qual nome gostaria de buscar na lista: ");
            nomeBusca = Console.ReadLine();

            nomeBusca = nomeBusca.Trim();
            nomeBusca = nomeBusca.ToLower();
            
            bool busca = false;

            for (int i = 0;i < nomes.Length; i++)
            {
                if (nomes[i] == nomeBusca)
                {
                    busca = true;
                    break;
                }              
            }

            if (busca)
            {
                Console.WriteLine("Achei");
            }
            else
            {
                Console.WriteLine("Não achei");
            }

            Console.ReadKey();
        }
    }
}
