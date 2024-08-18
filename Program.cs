using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");

Smartphone nokia = new Nokia(numero: "1234567", modelo: "Modelo_1", imei: "123AB", memoria: 169);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
  
Console.WriteLine("Iphone");

Smartphone iphone = new Iphone(numero: "123445678", modelo: "Modelo_2", imei: "123ABC", memoria: 246);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
