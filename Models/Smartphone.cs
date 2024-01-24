using System.Reflection.PortableExecutable;

namespace DesafioPOO.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    protected string Modelo { get; set; }
    protected int MemoriaRam { get; set; }
    protected int MemoriaInterna { get; set; }
    protected string Marca { get; set; }
    protected List<string> Aplicativos = new List<string>();
    protected bool EstaEmLigacao = false;

    public Smartphone()
    {
    }

    public Smartphone(string numero, string modelo, int memoriaRam, int memoriaInterna, string marca)
    {
        Numero = numero;
        Modelo = modelo;
        MemoriaRam = memoriaRam;
        MemoriaInterna = memoriaInterna;
        Marca = marca;
    }

    public void Informacoes()
    {
        Console.WriteLine
        ($"Informações do celular: Marca: {Marca}, Numero: {Numero}, Modelo: {Modelo}, Memória Ram: {MemoriaRam}, Memória interna: {MemoriaInterna}.");
    }

    public bool Ligar()
    {
        if (!EstaEmLigacao)
        {
            EstaEmLigacao = true;
            Console.WriteLine($"o Smartphone {Marca} - {Modelo} está ligando...");
            return true;
        }
        else
        {
            Console.WriteLine($" o Smartphone {Marca} - {Modelo} Já está Realizando uma ligação...");
            return false;
        }
    }

    public bool Desligar()
    {
        if (EstaEmLigacao)
        {
            EstaEmLigacao = false;
            Console.WriteLine($"o Smartphone {Marca} - {Modelo} Desligou a ligação...");
            return true;
        }
        else
        {
            Console.WriteLine($" o Smartphone {Marca} - {Modelo} Não está em ligação...");
            return false;
        }
    }

    public abstract bool InstalarAplicativo(string nomeApp);

    public bool DesistalarAplicativo(string nomeApp)
    {
        if (Aplicativos.Any(a => a.ToUpper() == nomeApp.ToUpper()))
        {
            Aplicativos.Remove(nomeApp);
            MemoriaInterna += 1;
            Console.WriteLine($"Aplicativo {nomeApp} foi removido com sucesso do seu {Marca} - {Modelo}");
            return true;
        }
        else
        {
            Console.WriteLine($"O aplicativo {nomeApp} não está instalado, por isso não será possivel remove-lo");
            return false;
        }
    }

}