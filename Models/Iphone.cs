using System;
using System.Collections.Generic;
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
            Console.WriteLine("Informe o nome do aplicativo que deseja instalar:");
            string nomeApp = Console.ReadLine();

            Console.WriteLine(@$"Ao prosseguir com a instalação será paga uma taxa de R$ 25,00
             deseja continuar?
             1- Sim
             2 - Não
             (Digite uma das opções)");

            string pagarTaxa = Console.ReadLine();

            if (pagarTaxa == "1")
            {
                Aplicativos.Add(nomeApp);

                Console.WriteLine($" O aplicativo {nomeApp} foi instalado com sucesso no seu Iphone - {Modelo}");
            }
            else
            {
                Console.WriteLine($"Não foi possivel instalar o aplicativo {nomeApp} no seu Iphone - {Modelo}");
            }

        }
    }

}