using SistemaEstacionamento.models;

// coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento! 🚗🚙🚓\n" + "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: 🪙⏱️");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento park = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// loop pra exibir o menu de opções
while (exibirMenu)
{

  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar veículo");
  Console.WriteLine("2 - Remover veículo");
  Console.WriteLine("3 - Listar veículos");
  Console.WriteLine("4 - Encerrar");

  switch (Console.ReadLine())
  {
    case "1":
      park.AdicionarVeiculo();
      break;

    case "2":
      park.RemoverVeiculo();
      break;

    case "3":
      park.ListarVeiculos();
      break;

    case "4":
      exibirMenu = false;
      break;

    default:
      Console.WriteLine("Opção inválida.");
      break;
  }

  Console.WriteLine("Pressione Enter para continuar.");
  Console.ReadLine();
}

Console.WriteLine("O programa se encerrou.");