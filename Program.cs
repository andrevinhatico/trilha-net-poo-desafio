using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone




Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111111111", memoria: 64);
Console.WriteLine($"Smartphone Nokia: Número - {nokia.Numero}");
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine($"\n");


Smartphone iphone = new Iphone(numero: "789156", modelo: "Modelo 2", imei: "222222222222222", memoria: 256);
Console.WriteLine($"Smartphone Nokia: Número - {iphone.Numero}");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");