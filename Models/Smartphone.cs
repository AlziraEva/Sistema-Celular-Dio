using System.Reflection.PortableExecutable;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected int MemoriaRam { get; set; }
        protected int MemoriaInterna { get; set; }
        protected string Marca { get; set; }
        protected List<string> Aplicativos = new List<string>();

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

        public void Ligar()
        {
            Console.WriteLine($"Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void ListarAplicativos()
        {
            if (Aplicativos.Any())
            {
                Console.WriteLine($"Os aplicativos instalados no {Marca} - {Modelo} foram:");

                foreach (string item in Aplicativos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"Não há aplicativos instalados no {Marca} - {Modelo}.");
            }
        }

    }
}