using DesafioPOO.Models;
// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine($@"Olá sou a Eva, sua assistente virtual,
Seja muito bem vindo(a) a criação de sistemas de Smartphones.
(Pressione a tecla 'Enter' para continuar.)");
Console.ReadLine();
Console.Clear();

Console.WriteLine($@"Qual número do seu Chip:");
string numero = Console.ReadLine();
Console.Clear();


Console.WriteLine($@"Me diga o modelo que deseja obter:");
string modelo = Console.ReadLine();
Console.Clear();

Console.WriteLine($@"Quantos GB de memória ram deseja:
 Disponiveis: 4, 6, 8, 16, 32 e 64
(digite apenas números)");
int memoriaRam = int.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine($@"Quantos GB de memória Interna deseja:
 Disponiveis: 32, 64, 128, 254, 1000
(digite apenas números)");
int memoriaInterna = int.Parse(Console.ReadLine());
Console.Clear();

string marca = "";

do
{
    Console.WriteLine("Escolha a Marca, temos 2 opções:");
    Console.WriteLine("1 - Nokia");
    Console.WriteLine("2 - Iphone");

    switch (Console.ReadLine())
    {
        case "1":
            marca = "Nokia";
            break;

        case "2":
            marca = "Iphone";
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine($@"Pressione a tecla 'Enter' para continuar.");
    Console.ReadLine();


} while (marca == "");
Console.Clear();

Smartphone celularNovo = new Marcas(numero, modelo, memoriaRam, memoriaInterna, marca);


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

    Console.WriteLine("Digite uma das opção:");
    Console.WriteLine("1 - Informações sobre o seu Smartphone");
    Console.WriteLine("2 - Realizar chamada telefonica");
    Console.WriteLine("3 - Receber chamada telefonica");
    Console.WriteLine("4 - Instalar Aplicativo");
    Console.WriteLine("5 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            celularNovo.Informacoes();
            break;

        case "2":
            celularNovo.Ligar();
            break;

        case "3":
            celularNovo.ReceberLigacao();
            break;

        case "4":
            Console.WriteLine("Informe o nome do aplicativo que deseja instalar:");
            string aplicativo = Console.ReadLine();
            celularNovo.InstalarAplicativo(aplicativo);
            break;

        case "5":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione a tecla 'Enter' para continuar");
    Console.ReadLine();

}








// Smartphone nokia = new Nokia("99999", "modelo x3", "66666", 10);
// nokia.Ligar("63635353");
// nokia.InstalarAplicativo("ZAP-Zap");

// Smartphone iphone = new Iphone("776627", "modelo yt", "77777", 32);
// iphone.ReceberLigacao();
// iphone.InstalarAplicativo("Nuvem aws");
// iphone.Ligar("1992882");
// iphone.Numero = "6666";
// iphone.Informacoes();