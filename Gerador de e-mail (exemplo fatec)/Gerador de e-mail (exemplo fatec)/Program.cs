using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_e_mail__exemplo_fatec_
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.Write("Qual o seu nome completo: ");

            string nome_completo = Console.ReadLine();

            string[] nome_separado = nome_completo.Split(' ');
            // Para gerar o e-mail precisamos cortar o nome completo em partes (elementos) utilizando a função split;

            string ultimo_sobrenome = nome_separado[nome_separado.Length - 1];
            // Como o e-mail é formado pelo último nome (sobrenome) com o primeiro nome, precisamos isolar o último nome, com a função Length -1;

            string primeiro_nome = nome_separado[0];
            // O primeiro nome é mais simples, sabendo que o nome já está separado, trata-se do primeiro elemento '0';

            string email = primeiro_nome + "." + ultimo_sobrenome + "@fatec.sp.gov.br";
            // Aqui é armazenado uma nova variável email por meio da concatenação de strings e palavras;

            Console.WriteLine("O seu e-mail da Faculdade de Tecnologia do Estado de São Paulo (FATEC) é: " + email);
            // isso permite que possa utilizar a nova variável email em outros projetos e continuações de trabalho;

            Console.ReadKey();
        }//fim
    }
}
