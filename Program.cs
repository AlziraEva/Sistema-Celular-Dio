using DesafioPOO.Models;
// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Iphone iphone = new Iphone("81 9999-9999", "J5", 6, 64, "Iphone");
iphone.Informacoes();
iphone.InstalarAplicativo("Zap");
iphone.Informacoes();
iphone.DesistalarAplicativo("Za");
iphone.DesistalarAplicativo("Zap");


