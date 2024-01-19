using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone()
        {
        }
        public Iphone(string numero, string modelo, int memoriaRam, int memoriaInterna, string marca)
      : base(numero, modelo, memoriaRam, memoriaInterna, marca)
        {
        }
        public override void InstalarAplicativo()
        {
            if (MemoriaInterna >= 1)
            {
                Console.WriteLine("Informe o nome do aplicativo que deseja instalar:");
                string nomeApp = Console.ReadLine();


                Console.WriteLine(@$"Ao prosseguir com a instalação será paga uma taxa de R$ 25,00
             deseja continuar?
             1 - Sim
             2 - Não
             (Digite uma das opções)");

                string pagarTaxa = Console.ReadLine();

                if (pagarTaxa == "1")
                {
                    Aplicativos.Add(nomeApp);
                    MemoriaInterna -= 1;

                    Console.WriteLine($" O aplicativo {nomeApp} foi instalado com sucesso no {Marca} - {Modelo}");
                }
                else
                {
                    Console.WriteLine($"Não foi possivel instalar o aplicativo {nomeApp} no seu {Marca} - {Modelo}");
                }
            }
            else
            {
                Console.WriteLine($@"Seu Smartphone {Marca} - {Modelo} não possui memória suficiente para a instalação,
                Caso deseje, pode liberar espaço desistalando algum dos aplicativos existentes.");
            }

        }
    }

}