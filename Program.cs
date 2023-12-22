using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "G11 Plus", "306030857397556", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Gwent");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("987654321", "14 Plus", "545548703634584", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("IconPop");