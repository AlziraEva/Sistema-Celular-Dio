using System.Reflection.PortableExecutable;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string modelo;
        private int memoriaRam;
        private int memoriaInterna;

        public Smartphone(string numero, string modeloCel, int memoriaRamCel, int memoriaInternaCel)
        {
            Numero = numero;
            modelo = modeloCel;
            memoriaRam = memoriaRamCel;
            memoriaInterna = memoriaInternaCel;
        }

        public void Informacoes()
        {
            Console.WriteLine
            ($"Informações do celular: Numero: {Numero}, Modelo: {modelo}, Memória Ram: {memoriaRam}, Memória interna: {memoriaInterna}.");
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