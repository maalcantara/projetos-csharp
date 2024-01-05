using System;

class Program
{
  static void Main()
  {
    try
    {
      // solicita os dados para o cálculo:
      Console.WriteLine("Digite seu nome: 🙋");
      string nome = Console.ReadLine();

      Console.WriteLine("Digite a quantidade de quilômetros percorridos por dia: 👟");
      double quilometrosPorDia = double.Parse(Console.ReadLine());

      Console.WriteLine("Digite a quantidade de horas de uso de eletrônicos por dia: 📱");
      int horasDeEletronicos = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o número de refeições com carne por dia: 🍖");
      int refeicoesComCarne = int.Parse(Console.ReadLine());

      // chama o método para calcular a pegada de carbono
      double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

      // exibe o resultado para o usuário:
      Console.WriteLine($"{nome}, sua pegada de carbono é de {pegadaDeCarbono:F2} toneladas de CO2 por ano. 🌫️");

      // espera a entrada do usuário antes de encerrar o programa
      Console.WriteLine("Aperte a tecla 'enter' para sair do programa.");
      Console.ReadLine();
    }
    catch (FormatException)
    {
      Console.WriteLine("Erro: Entrada inválida. Certifique-se de digitar números nos campos apropriados.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Erro inesperado: {ex.Message}");
    }
  }

  // método que calcula a pegada de carbono com base nos parâmetros fornecidos:
  static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
  {
    // fatores de emissão específicos
    double fatorTransporte = 0.2;
    double fatorEletronicos = 0.1;
    double fatorCarne = 0.5;

    // cálculo da pegada de carbono total
    double pegadaTotal = (quilometrosPorDia * 365 * fatorTransporte) + (horasDeEletronicos * fatorEletronicos) + (refeicoesComCarne * fatorCarne);

    return pegadaTotal;
  }
}
