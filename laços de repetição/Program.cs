using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laços_de_repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=1;
            int numero1=0;
            for(int i=1; i<=numero; i++)
            {
                Console.WriteLine("Repetição de número " + i);
            }
            Console.ReadKey();

            while (numero1!=100)
            {
                Console.WriteLine("Repetindo o while... ");
                numero1 = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Executado 1 vez");
            } while (numero == 1);

            Console.ReadKey();
      }
   }
}
