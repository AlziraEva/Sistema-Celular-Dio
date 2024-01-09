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
        public Iphone(string Numero, string modelo, int memoriaRam, int memoriaInterna, string marca)
      : base(Numero, modelo, memoriaRam, memoriaInterna, marca)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {

            Console.WriteLine(@$"Ao prosseguir com a instalação será paga uma taxa de R$ 25,00
             deseja continuar?
             1- Sim
             2 - Não
             (Digite uma das opções)");

            string pagarTaxa = Console.ReadLine();

            if (pagarTaxa == "1")
            {
                aplicativos.Add(nomeApp);

                Console.WriteLine($" O aplicativo {nomeApp} foi instalado com sucesso no seu Iphone - {modelo}");
            }
            else
            {
                Console.WriteLine($"Não foi possivel instalar o aplicativo {nomeApp} no seu Iphone - {modelo}");
            }

        }
    }

}