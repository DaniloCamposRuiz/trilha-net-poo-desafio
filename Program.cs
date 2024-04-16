using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Feito
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia Tijolão", imei: "11111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "15", imei: "2222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");