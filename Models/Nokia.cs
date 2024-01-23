using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models;

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

        if (MemoriaInterna >= 2 && !Aplicativos.Any(a => a.ToUpper() == nomeApp.ToUpper()))
        {
            Aplicativos.Add(nomeApp);
            MemoriaInterna -= 2;

            Console.WriteLine($" O aplicativo {nomeApp} foi instalado com sucesso no {Marca} - {Modelo}");
        }
        else
        {
            Console.WriteLine($@"Seu Smartphone {Marca} - {Modelo} não possui memória suficiente para a instalação,
                Caso deseje, pode liberar espaço desistalando algum dos aplicativos existentes.");
        }
    }
}
