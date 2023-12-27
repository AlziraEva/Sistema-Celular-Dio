namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string modelo;
        private string imei;
        private int memoria;

        public Smartphone(string numero, string modeloCel, string imeiCel, int memoriaCel)
        {
            Numero = numero;
            modelo = modeloCel;
            imei = imeiCel;
            memoria = memoriaCel;
        }

        public void Informacoes()
        {
            Console.WriteLine
            ($"Informações do celular: Numero: {Numero}, Modelo: {modelo}, Imei: {imei}, Memória: {memoria}.");
        }

        public void Ligar(string numeroligar)
        {
            Console.WriteLine($"Ligando para o número {numeroligar}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}