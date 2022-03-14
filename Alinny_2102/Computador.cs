using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Alinny_2102
{
    class Computador
    {
        string processador;
        string mem_ram;
        string pl_video;
        string armazenamento;
        string pl_mae;
        string fonte;
        int qtde_computadores;



        public void cadastrar()
        {
            Console.WriteLine("Quantos computadors serão cadatrados?");
            qtde_computadores = int.Parse(Console.ReadLine());



            for (int i = 0; i < qtde_computadores; i++)
            {
                Console.WriteLine("Digite o modelo do processador: ");
                processador = Console.ReadLine();
                Console.WriteLine("Digite o modelo da memória RAM: ");
                mem_ram = Console.ReadLine();
                Console.WriteLine("Digite o modelo da placa de vídeo: ");
                pl_video = Console.ReadLine();
                Console.WriteLine("Digite o modelo do armazenamento: ");
                armazenamento = Console.ReadLine();
                Console.WriteLine("Digite o modelo da placa mãe: ");
                pl_mae = Console.ReadLine();
                Console.WriteLine("Digite o modelo da fonte: ");
                fonte = Console.ReadLine();
            }

        }
        public void exibir()
        {
            Console.WriteLine("Sua configuração atual: ");
            Console.WriteLine("Prcessador: {0}\n,Memória RAM: {1}\n,Placa de Vídeo: {2}\n,Armazenamento: {3}\n,Placa mãe: {4}\n,Fonte: {5}", processador, mem_ram, pl_video, armazenamento, pl_mae, fonte);
            Console.ReadKey();
        }
    }
}
