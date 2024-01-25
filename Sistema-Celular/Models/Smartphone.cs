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
    private bool EstaEmLigacao = false;

    public Smartphone()
    {
    }

    public Smartphone(string numero, string modelo, int memoriaRam, int memoriaInterna, string marca)
    {
        Numero = !string.IsNullOrWhiteSpace(numero)
            ? numero
            : throw new ArgumentNullException("numero", "O número não pode ser nulo, vazio ou conter apenas espaços em branco.");

        Modelo = !string.IsNullOrWhiteSpace(modelo)
                ? modelo
                : throw new ArgumentNullException("modelo", "O modelo não pode ser nulo, vazio ou conter apenas espaços em branco.");

        MemoriaRam = memoriaRam > 0
            ? memoriaRam
            : throw new ArgumentOutOfRangeException("memoriaRam", "A memória RAM deve ser maior que zero.");

        MemoriaInterna = memoriaInterna > 0
                ? memoriaInterna
                : throw new ArgumentOutOfRangeException("memoriaInterna", "A memória interna deve ser maior que zero.");

        Marca = !string.IsNullOrWhiteSpace(marca)
                ? marca
                : throw new ArgumentNullException("marca", "A marca não pode ser nula, vazia ou conter apenas espaços em branco.");
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


        Console.WriteLine($"O aplicativo {nomeApp} não está instalado, por isso não será possivel remove-lo");
        return false;

    }

}