using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case_interacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            int op;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("╔═══════════════════════════════════════════════╗");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 14);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 15);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 16);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 17);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 18);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 19);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 20);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(3, 21);
            Console.WriteLine("╚═══════════════════════════════════════════════╝");

            Console.SetCursorPosition(6, 11);
            Console.WriteLine("CÓDIGO");
            Console.SetCursorPosition(6, 12);
            Console.WriteLine("1");
            Console.SetCursorPosition(6, 13);
            Console.WriteLine("2");
            Console.SetCursorPosition(6, 14);
            Console.WriteLine("3");
            Console.SetCursorPosition(6, 15);
            Console.WriteLine("4");
            Console.SetCursorPosition(16, 11);
            Console.WriteLine("CARGO");
            Console.SetCursorPosition(16, 12);
            Console.WriteLine("Gerente");
            Console.SetCursorPosition(16, 13);
            Console.WriteLine("Analista");
            Console.SetCursorPosition(16, 14);
            Console.WriteLine("Técnico");
            Console.SetCursorPosition(16, 15);
            Console.WriteLine("Outro");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Qual o seu código do cargo: ");
            Console.SetCursorPosition(5, 6);
            int cod = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("Qual o seu cargo: ");
            Console.SetCursorPosition(5, 8);
            string cargo = Console.ReadLine();
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("Qual o seu salário: ");
            Console.SetCursorPosition(5, 10);
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.SetCursorPosition(5, 13);
            Console.WriteLine("Qual o seu código do cargo novamente: ");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("CÓDIGO");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("1");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("2");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("3");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("4");
            Console.SetCursorPosition(15, 5);
            Console.WriteLine("CARGO");
            Console.SetCursorPosition(15, 6);
            Console.WriteLine("Gerente");
            Console.SetCursorPosition(15, 7);
            Console.WriteLine("Analista");
            Console.SetCursorPosition(15, 8);
            Console.WriteLine("Técnico");
            Console.SetCursorPosition(15, 9);
            Console.WriteLine("Outro");
            Console.SetCursorPosition(25, 5);
            Console.WriteLine("AUMENTO");
            Console.SetCursorPosition(25, 6);
            Console.WriteLine("10%");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("20%");
            Console.SetCursorPosition(25, 8);
            Console.WriteLine("30%");
            Console.SetCursorPosition(25, 9);
            Console.WriteLine("40%");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(5, 14);
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.SetCursorPosition(5, 15);
                    Console.WriteLine("Gerente");
                    Console.SetCursorPosition(5, 16);
                    Console.WriteLine("Seu salário é: R$  " + salario);
                    Console.SetCursorPosition(5, 17);
                    double salario_futuro_gerent = salario * 1.10;
                    Console.WriteLine("O resultado da soma é: " + salario_futuro_gerent);
                    break;
                case 2:
                    Console.SetCursorPosition(5, 15);
                    Console.WriteLine("Analista");
                    Console.SetCursorPosition(5, 16);
                    Console.WriteLine("Seu salário é: R$  " + salario);
                    Console.SetCursorPosition(5, 17);
                    double salario_futuro_analist = salario * 1.20;
                    Console.WriteLine("O resultado da soma é: " + salario_futuro_analist);
                    break;
                case 3:
                    Console.SetCursorPosition(5, 15);
                    Console.WriteLine("Técnico");
                    Console.SetCursorPosition(5, 16);
                    Console.WriteLine("Seu salário é: R$  " + salario);
                    Console.SetCursorPosition(5, 17);
                    double salario_futuro_tec = salario * 1.30;
                    Console.WriteLine("O resultado da soma é: " + salario_futuro_tec);
                    break;
                case 4:
                    Console.SetCursorPosition(5, 15);
                    Console.WriteLine("Outros");
                    Console.SetCursorPosition(5, 16);
                    Console.WriteLine("Seu salário é: R$  " + salario);
                    Console.SetCursorPosition(5, 17);
                    double salario_futuro_outro = salario * 1.40;
                    Console.WriteLine("O resultado da soma é: " + salario_futuro_outro);
                    break;
                case 5:
                    Console.WriteLine("Sair");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Nenhuma das opçoes.");
                    goto inicio;
            }
            Console.ReadKey();
        }
    }
}
