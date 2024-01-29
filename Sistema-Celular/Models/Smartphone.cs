using System.Reflection.PortableExecutable;

namespace DesafioPOO.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; protected set; }
    public int MemoriaRam { get; protected set; }
    public int MemoriaInterna { get; protected set; }
    public string Marca { get; protected set; }
    protected List<string> Aplicativos = new List<string>();
    private bool NaoEstaEmLigacao = false;

    public Smartphone()
    {
    }

    public Smartphone(string numero, string modelo, int memoriaRam, int memoriaInterna, string marca)
    {
        Numero = string.IsNullOrWhiteSpace(numero)
            ? throw new ArgumentNullException("numero", "O número não pode ser nulo, vazio ou conter apenas espaços em branco.")
            : numero;

        Modelo = string.IsNullOrWhiteSpace(modelo)
                ? throw new ArgumentNullException("modelo", "O modelo não pode ser nulo, vazio ou conter apenas espaços em branco.")
                : modelo;

        MemoriaRam = memoriaRam > 0
            ? memoriaRam
            : throw new ArgumentOutOfRangeException("memoriaRam", "A memória RAM deve ser maior que zero.");

        MemoriaInterna = memoriaInterna > 0
                ? memoriaInterna
                : throw new ArgumentOutOfRangeException("memoriaInterna", "A memória interna deve ser maior que zero.");

        Marca = string.IsNullOrWhiteSpace(marca)
                ? throw new ArgumentNullException("marca", "A marca não pode ser nula, vazia ou conter apenas espaços em branco.")
                : marca;
    }

    public void Informacoes()
    {
        Console.WriteLine
        ($"Informações do celular: Marca: {Marca}, Numero: {Numero}, Modelo: {Modelo}, Memória Ram: {MemoriaRam}, Memória interna: {MemoriaInterna}.");
    }

    public bool Ligar()
    {
        if (NaoEstaEmLigacao)
        {
            Console.WriteLine($" o Smartphone {Marca} - {Modelo} Já está Realizando uma ligação...");
            return false;
        }

        NaoEstaEmLigacao = true;
        Console.WriteLine($"o Smartphone {Marca} - {Modelo} está ligando...");
        return true;

    }

    public bool Desligar()
    {
        if (NaoEstaEmLigacao)
        {
            NaoEstaEmLigacao = false;
            Console.WriteLine($"o Smartphone {Marca} - {Modelo} Desligou a ligação...");
            return true;
        }

        Console.WriteLine($" o Smartphone {Marca} - {Modelo} Não está em ligação...");
        return false;

    }

    public abstract bool InstalarAplicativo(string nomeApp);

    public bool DesistalarAplicativo(string nomeApp)
    {
        if (Aplicativos.Any(a => a.ToUpper() == nomeApp.ToUpper()))
        {
            Aplicativos.Remove(nomeApp.ToUpper());
            MemoriaInterna += 1;
            Console.WriteLine($"Aplicativo {nomeApp} foi removido com sucesso do seu {Marca} - {Modelo}");
            return true;
        }

        Console.WriteLine($"O aplicativo {nomeApp} não está instalado, por isso não será possivel remove-lo");
        return false;
    }

}