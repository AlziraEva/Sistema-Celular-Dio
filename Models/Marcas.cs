using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Marcas : Smartphone
    {
        private string nomeMarca;
        public Marcas(string numero, string modeloCel, int memoriaRamCel, int memoriaInternaCel, string marcaCel)
      : base(numero, modeloCel, memoriaRamCel, memoriaInternaCel)
        {
            nomeMarca = marcaCel;
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no {nomeMarca}");
        }
    }
}