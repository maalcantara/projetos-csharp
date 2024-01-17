using System;
using System.Text;
using System.Collections.Generic;
using SistemaHospedagem.models;

class Program
{
  static void Main()
  {
    Console.Output = Encoding.UTF8;

    // solicita informações sobre os hóspedes
    List<Pessoa> hospedes = new List<Pessoa>();
    for (int i = 1; i <= 2; i++)
    {
      Console.WriteLine($"Digite o nome do hóspede {i}: ");
      string nomeHospede = Console.ReadLine();
      hospedes.Add(new Pessoa(nomeHospede));
    }

    // Solicita informações sobre a suíte
    Console.WriteLine("Digite o tipo da suíte: ");
    Console.WriteLine("1 - Premium 👑\n2 - Master 🔮\n3 - Comum 🌿");
    string tipoSuite = Console.ReadLine();

    Console.WriteLine("Digite a capacidade da suíte: ");
    int capacidadeSuite;
    while (!int.TryParse(Console.ReadLine(), out capacidadeSuite) || capacidadeSuite <= 0)
    {
      Console.WriteLine("Capacidade invalida. Digite um valor positivo.");
    }

    Console.WriteLine("Digite o valor da diária da suíte: 💵 ");
    decimal valorDiaria;
    while (!decimal.TryParse(Console.ReadLine(), out valorDiaria) || valorDiaria <= 0)
    {
      Console.WriteLine("Valor inválido.");
    }

    // cria a suíte com as infos fornecidas
    Suite suite = new Suite(tipoSuite, capacidadeSuite, valorDiaria);

    // pede as infos sobre a reserva
    Console.WriteLine("Digite o número de dias de reserva: ");
    int diasReservados;
    while (!int.TryParse(Console.ReadLine(), out diasReservados) || diasReservados <= 0)
    {
      Console.WriteLine("Número de dias inválido. Digite um valor inteiro positivo.");
    }

    // cria a reserva e realiza o cadastro
    Reserva reserva = new Reserva(diasReservados);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    // mostra a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()} 👯");
    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()} 💵☀️");
    Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorTotal()} 💶");
  }
}
