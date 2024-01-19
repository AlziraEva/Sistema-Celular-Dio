using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia()
        {
        }
        public Nokia(string numero, string modelo, int memoriaRam, int memoriaInterna, string marca)
      : base(numero, modelo, memoriaRam, memoriaInterna, marca)
        {
        }
        public override void InstalarAplicativo()
        {
            Console.WriteLine("Informe o nome do aplicativo que deseja instalar:");
            string nomeApp = Console.ReadLine();

            Aplicativos.Add(nomeApp);

            Console.WriteLine($" O aplicativo {nomeApp} foi instalado com sucesso no Nokia - {Modelo}");
        }
    }
}