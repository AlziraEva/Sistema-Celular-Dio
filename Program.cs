using DesafioPOO.Models;

Smartphone nokia = new Nokia("99999", "modelo x3", "66666", 10);
nokia.Ligar("63635353");
nokia.InstalarAplicativo("ZAP-Zap");

Smartphone Iphone = new Iphone("776627", "modelo yt", "77777", 32);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Nuvem aws");
Iphone.Ligar("1992882");
Iphone.Numero = "6666";
Iphone.Informacoes();