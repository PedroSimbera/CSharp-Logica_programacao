using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case_calculos_bask_forc_vel
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
            Console.WriteLine("║                                                ║");
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
            Console.SetCursorPosition(6, 5);
            Console.WriteLine("1 - BASKARA");
            Console.SetCursorPosition(6, 6);
            Console.WriteLine("2 - FORÇA");
            Console.SetCursorPosition(6, 7);
            Console.WriteLine("3 - VELOCIDADE");
            Console.SetCursorPosition(6, 8);
            Console.WriteLine("4 - SAIR ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(25, 4);
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {

                case 1:
                    Console.SetCursorPosition(25, 4);
                    Console.WriteLine("BASKARA");
                    double a, b, c, delta, x1, x2;
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("Digite o valor de A ");
                    Console.SetCursorPosition(25, 6);
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 7);
                    Console.WriteLine("Digite o valor de B ");
                    Console.SetCursorPosition(25, 8);
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 9);
                    Console.WriteLine("Digite o valor de C ");
                    Console.SetCursorPosition(25, 10);
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 11);
                    delta = Math.Pow(b, 2) - 4 * a * c;
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.SetCursorPosition(25, 12);
                    Console.WriteLine("O valor de delta é: " + delta);
                    Console.SetCursorPosition(25, 13);
                    Console.WriteLine("o valor de x1 é: " + x1.ToString("F2"));
                    Console.SetCursorPosition(25, 14);
                    Console.WriteLine("o valor de x2 é: " + x2.ToString("F2"));
                    break;
                case 2:
                    Console.SetCursorPosition(25, 4);
                    Console.WriteLine("FORÇA");
                    double f, m, ace;
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("Digite a massa: ");
                    Console.SetCursorPosition(25, 6);
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 7);
                    Console.WriteLine("Digite a aceleração: ");
                    Console.SetCursorPosition(25, 8);
                    ace = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 9);
                    f = m * ace;
                    Console.WriteLine("A força é: " + f);
                    break;
                case 3:
                    Console.SetCursorPosition(25, 4);
                    Console.WriteLine("VELOCIDADE");
                    double Velo, Vcini, acel, tempo;
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("Digite a velocidade inicial: ");
                    Console.SetCursorPosition(25, 6);
                    Vcini = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 7);
                    Console.WriteLine("Digite a aceleração: ");
                    Console.SetCursorPosition(25, 8);
                    acel = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(25, 9);
                    Console.WriteLine("Digite o tempo em minutos: ");
                    Console.SetCursorPosition(25, 10);
                    tempo = Convert.ToDouble(Console.ReadLine());
                    Velo = Vcini + acel * tempo;
                    Console.SetCursorPosition(25, 11);
                    Console.WriteLine("A velocidade: " + Velo);
                    break;
                case 4:
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
