using System.Reflection.PortableExecutable;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string modelo { get; set; }
        protected int memoriaRam { get; set; }
        protected int memoriaInterna { get; set; }
        protected string marca { get; set; }

        public Smartphone()
        {
        }

        public Smartphone(string numero, string modeloCel, int memoriaRamCel, int memoriaInternaCel, string marcaCel)
        {
            Numero = numero;
            modelo = modeloCel;
            memoriaRam = memoriaRamCel;
            memoriaInterna = memoriaInternaCel;
            marca = marcaCel;
        }

        public void Informacoes()
        {
            Console.WriteLine
            ($"Informações do celular: Marca: {marca}, Numero: {Numero}, Modelo: {modelo}, Memória Ram: {memoriaRam}, Memória interna: {memoriaInterna}.");
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

    }
}