namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modeloCel, string imeiCel, int memoriaCel) : base(numero, modeloCel, imeiCel, memoriaCel)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
        }
    }
}