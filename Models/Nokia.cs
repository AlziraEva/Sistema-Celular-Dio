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
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}