using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    class Calculadora
    {
        double valor1;
        double valor2;
        double valor3;
        int escolha;
        
        public void soma()
        {
            Console.Write("Digite o valor 1 da soma:");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor 2 da soma:");
            valor2 = double.Parse(Console.ReadLine());
            valor3 = valor1 + valor2;
            Console.WriteLine(valor1 + "+" + valor2 + "=" + valor3);
        }
        public void subtracao() {
            Console.Write("Digite o valor 1 da subtração:");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor 2 da subtração:");
            valor2 = double.Parse(Console.ReadLine());
            valor3 = valor1 - valor2;
            Console.WriteLine(valor1 + "-" + valor2 + "=" + valor3);
        }
        public void multiplicaçao()
        {
            Console.Write("Digite o valor 1 da multiplicação:");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor 2 da multiplicação:");
            valor2 = double.Parse(Console.ReadLine());
            valor3 = valor1 * valor2;
            Console.WriteLine(valor1 + "*" + valor2 + "=" + valor3);
        }
        public void divisao()
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
        public void selecionar()
        {
            Console.WriteLine("Digite 1 para somar, 2 para subtrair, 3 para multiplicar e 4 para dividir.");
            escolha = int.Parse(Console.ReadLine());
            while (escolha>4 && escolha<=0)
            {
                Console.WriteLine("Escreva um número válido::");
                escolha = int.Parse(Console.ReadLine());
            }
            if (escolha==1) {
                soma();
                refaz();
            }
            if(escolha == 2)
            {
                subtracao();
                refaz();
            }
            if (escolha == 3)
            {
                multiplicaçao();
                refaz();
            }
            if (escolha == 4)
            {
                divisao();
                refaz();
            }
        }
        
        public void refaz()
        {
            Console.WriteLine("Para continuar calculando, digite +, caso contrário, apenas dê ENTER.");
            string calculo = Console.ReadLine();
            Console.Clear();
            if (calculo == "+")
            {
                selecionar();
            }
            else
            {
                Console.WriteLine("--calculo encerrado--");
            }
        }
    }
}
