using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234567", modelo: "modelo 1", imei: "11111111111", memoria: "64");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "78543", modelo: "modelo 2", imei: "2222222222", memoria: "128");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");