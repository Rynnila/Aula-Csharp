using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraALinny
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            double valor1;
            double valor2;
            double valor3;
            Console.WriteLine("Digite 1 para somar, 2 para subtrair, 3 para multiplicar e 4 para dividir.");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.Write("Digite o valor 1 da subtração:");
                valor1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor 2 da subtração:");
                valor2 = double.Parse(Console.ReadLine());
                valor3 = valor1 - valor2;
                Console.WriteLine(valor1 + "-" + valor2 + "=" + valor3);
            }
            if (escolha == 2)
            {
                Console.Write("Digite o valor 1 da soma:");
                valor1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor 2 da soma:");
                valor2 = double.Parse(Console.ReadLine());
                valor3 = valor1 + valor2;
                Console.WriteLine(valor1 + "+" + valor2 + "=" + valor3);
            }
            if (escolha == 3)
            {
                Console.Write("Digite o valor 1 da multiplicação:");
                valor1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor 2 da multiplicação:");
                valor2 = double.Parse(Console.ReadLine());
                valor3 = valor1 * valor2;
                Console.WriteLine(valor1 + "*" + valor2 + "=" + valor3);
            }
            if (escolha == 4)
            {
                Console.Write("Digite o valor 1 da divisão:");
                valor1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor 2 da divisão:");
                valor2 = double.Parse(Console.ReadLine());
                if (valor2 != 0)
                {
                    valor3 = valor1 / valor2;
                    Console.WriteLine(valor1 + "/" + valor2 + "=" + valor3);
                }
                else
                {
                    Console.WriteLine("Não é possível dividir");
                    valor3 = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
