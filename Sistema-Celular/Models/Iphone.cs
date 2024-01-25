using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models;

public class Iphone : Smartphone
{
    public Iphone()
    {
    }

    public Iphone(string numero, string modelo, int memoriaRam, int memoriaInterna, string marca)
  : base(numero, modelo, memoriaRam, memoriaInterna, marca)
    {
    }
    public override bool InstalarAplicativo(string nomeApp)
    {
        if (MemoriaInterna >= 1 && !Aplicativos.Any(a => a.ToUpper() == nomeApp.ToUpper()))
        {
            Aplicativos.Add(nomeApp);
            MemoriaInterna -= 1;
            Console.WriteLine($" O aplicativo {nomeApp} foi instalado com sucesso no {Marca} - {Modelo}");
            return true;
        }

        Console.WriteLine(@$"Seu Smartphone {Marca} - {Modelo} não possui memória suficiente
            ou esse aplicativo já está instalado no sistema");
        return false;


    }

}
