using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alinny_2102
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;
            string sobrenome;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine("\"Como foi seu dia?\", "+nome);
            Console.Write("Insira a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu nome é {0} {1} e a sua idade é: {2} anos.",nome, sobrenome, idade);
            Console.ReadKey();

            Computador lab = new Computador();
            lab.cadastrar();
            lab.exibir();
        }
    }
}