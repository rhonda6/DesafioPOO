using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smarthphone Nokia:");
Smartphone nokia = new Nokia("12345", "Modelo Nokia 1", "1111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Chrome");

Console.WriteLine("Smarthphone Iphone:");
Smartphone iphone = new Iphone("78910", "Modelo Iphone 1", "2222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");