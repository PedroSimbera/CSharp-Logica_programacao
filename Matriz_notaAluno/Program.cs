using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_notaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio
            int qtdaluno, qtdnota, i, j;
            double somaNota;
            string notastring;
            
            Console.Write("Quantos alunos há na sala: ");
            qtdaluno= Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantas avaliações foram realizadas: ");
            qtdnota= Convert.ToInt32(Console.ReadLine());

            string[,] notasMedia = new string[qtdaluno,qtdnota+1];
            double[,] notasMediaCopia = new double[qtdaluno, qtdnota];

            //recebendo os valores
            for (i = 0;i < qtdaluno; i++)
            {
                Console.Write("Digite o nome do " + (i + 1) + "º aluno: ");
                notasMedia[i, 0] = Console.ReadLine();

                for (j = 0; j < qtdnota; j++)
                {
                    Console.Write("Digite a " + (j+1) + "º nota do " + (i + 1) + "º aluno: ");
                    notastring = Console.ReadLine();
                    notasMedia[i, j + 1] = notastring;
                    notasMediaCopia[i,j] = Convert.ToDouble(notastring);
                }
            }

            //realizando o cálculo das médias
            for (i = 0; i < qtdaluno; i++)
            {
                somaNota = 0;

                for (j = 0; j < qtdnota; j++)
                {
                    somaNota += notasMediaCopia[i, j];
                }
                Console.WriteLine();
                double mediaAluno = somaNota / qtdnota;
                Console.WriteLine("A média do aluno " + notasMedia[i, 0] + " é: " + mediaAluno);               
            }

            Console.ReadKey();

        }//fim
    }     
}

