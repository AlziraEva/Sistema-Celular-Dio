using DesafioPOO.Models;
// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine($@"Olá sou a Eva, sua assistente virtual,
Seja muito bem vindo(a) a criação de um sistema para Smartphone.
(Pressione a tecla 'Enter' para continuar.)");
Console.ReadLine();
Console.Clear();

Console.WriteLine($@"Qual número do seu Chip:");
string numero = Console.ReadLine();
Console.Clear();

Console.WriteLine($@"Me diga o modelo que deseja obter:");
string modelo = Console.ReadLine();
Console.Clear();

int memoriaRam = 0;
do
{
    Console.WriteLine($@"Quantos GB de memória ram deseja:
    (Digite uma das opções abaixo)
     1 - 6 GB
     2 - 8 GB
     3 - 12 GB");

    switch (Console.ReadLine())
    {

        case "1":
            memoriaRam = 6;
            break;

        case "2":
            memoriaRam = 8;
            break;

        case "3":
            memoriaRam = 12;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine($@"Pressione a tecla 'Enter' para continuar.");
    Console.ReadLine();
    Console.Clear();

} while (memoriaRam == 0);
Console.Clear();

int memoriaInterna = 0;
do
{
    Console.WriteLine($@"Quantos GB de memória Interna deseja:
    (Digite uma das opções abaixo)
    1 - 64 GB
    2 - 128 GB
    3 - 256 GB");
    switch (Console.ReadLine())
    {
        case "1":
            memoriaInterna = 64;
            break;

        case "2":
            memoriaInterna = 128;
            break;

        case "3":
            memoriaInterna = 256;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;

    }
    Console.WriteLine($@"Pressione a tecla 'Enter' para continuar.");
    Console.ReadLine();
    Console.Clear();

} while (memoriaInterna == 0);
Console.Clear();

Smartphone sistemaNovo = new Nokia();
string marca = "";
do
{
    Console.WriteLine($@"Escolha a Marca, temos 2 opções:
    1 - Nokia
    2 - Iphone");

    switch (Console.ReadLine())
    {
        case "1":
            marca = "Nokia";
            sistemaNovo = new Nokia(numero, modelo, memoriaRam, memoriaInterna, marca);
            break;

        case "2":
            marca = "Iphone";
            sistemaNovo = new Iphone(numero, modelo, memoriaRam, memoriaInterna, marca);
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine($@"Pressione a tecla 'Enter' para continuar.");
    Console.ReadLine();
    Console.Clear();

} while (marca == "");
Console.Clear();

Console.WriteLine($@"Muito bem, seu Smartphone está ficando lindão *.*
Aguarde só alguns instantes...
");
Console.WriteLine($@"Olha quem acabou de sair do forninho,
antes de mais nada vamos testar algumas funcionalidades do sistema.");
Console.WriteLine($@"Pressione a tecla 'Enter' para continuar.");
Console.ReadLine();
Console.Clear();

bool exibirMenu = true;
while (exibirMenu)
{
    Console.WriteLine($@"Digite uma das opção:
    1 - Informações sobre o seu Smartphone
    2 - Realizar chamada 
    3 - Receber chamada telefonica
    4 - Instalar Aplicativo
    5 - Listar Aplicativos instalados
    6 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            sistemaNovo.Informacoes();
            break;

        case "2":
            sistemaNovo.Ligar();
            break;

        case "3":
            sistemaNovo.ReceberLigacao();
            break;

        case "4":
            Console.WriteLine("Informe o nome do aplicativo que deseja instalar:");
            string aplicativo = Console.ReadLine();
            sistemaNovo.InstalarAplicativo(aplicativo);
            break;

        case "5":
            sistemaNovo.ListarAplicativos();
            break;

        case "6":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione a tecla 'Enter' para continuar");
    Console.ReadLine();
    Console.Clear();

}