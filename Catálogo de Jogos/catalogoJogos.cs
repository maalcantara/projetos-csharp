using System;

class Program
{
  // variáveis estáticas (const)
  const string MsgQuantJogos = "Quantos jogos deseja adicionar? 🕹️";
  const string MsgNomeJogo = "Digite o nome do jogo #{0}: 🎮";

  static void Main()
  {
    int quantJogos;

    // validação de entrada de um nº válido
    while (true)
    {
      Console.WriteLine(MsgQuantJogos);

      if (int.TryParse(Console.ReadLine(), out quantJogos) && quantJogos > 0)
        break;
      Console.WriteLine("Insira um número válido.");
    }

    string[] nomesJogos = new string[quantJogos];

    for (int i = 0; i < quantJogos; i++)
    {
      AdicionarJogo(i, nomesJogos);
    }

    ExibirResumoAddJogos(quantJogos, nomesJogos);
  }

  static void AdicionarJogo(int indice, string[] nomes)
  {
    Console.WriteLine(string.Format(MsgNomeJogo, indice + 1));
    nomes[indice] = Console.ReadLine();
  }

  static void ExibirResumoAddJogos(int quantJogos, string[] nomes)
  {
    Console.WriteLine($"Foram adicionados {quantJogos} jogos: {string.Join(", ", nomes)} ao catálogo.");
  }
}