using Csharp.projetos-csharp.Gerenciamento Celular.Models;

// instanciar as classes
IPhone smartphone1 = new(numero: "123456789", modelo: "x10", imei: "abc123", memoria: 32);
Samsung smartphone2 = new(numero: "987654321", modelo: "a20", imei: "bcd456", memoria: 64);
Xiaomi smartphone3 = new(numero: "26810121", modelo: "k12", imei: "mdf768", memoria: 128);

// métodos

Console.WriteLine("Smartphone iPhone: 📱");
smartphone1.Ligar();
smartphone1.ReceberLigacao();
smartphone1.InstalarAplicativo(nomeApp: "jogo da cobrinha", modelo: smartphone1.Modelo);

Console.WriteLine("\n");

Console.WriteLine("Smartphone Samsung: 📱");
smartphone2.Ligar();
smartphone2.ReceberLigacao();
smartphone2.InstalarAplicativo(nomeApp: "whatsapp", modelo: smartphone2.Modelo);

Console.WriteLine("\n");

Console.WriteLine("Smartphone Xiaomi: 📱");
smartphone3.Ligar();
smartphone3.ReceberLigacao();
smartphone3.InstalarAplicativo(nomeApp: "instagram", modelo: smartphone3.Modelo);