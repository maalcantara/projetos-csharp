using System.Globalization;
using Newtonsoft.Json;

// criação de Listas (Filas e Pilhas)

Queue<int> fila = new Queue<int>();
fila.Enqueue(0); // add item na fila
fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Dequeue(); // remover 1º item da fila
foreach (int item in fila)
{
  Console.WriteLine(item);
}

Stack<int> pilha = new Stack<int>();
pilha.Push(0); // add item na pilha
pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Pop(); // remover 1º item da pilha
foreach (int item in pilha)
{
  Console.WriteLine(item);
}

// Criação de um Dictionary

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "Sao Paulo"); // "SP" é a key e "Sao Paulo é o value
estados.Add("AM", "Amazonas");
estados.Add("BA", "Bahia");
estados.Remove("BA"); // remover item
estados["SP"] = "São Paulo"; // alterar o value
foreach (var item in estados)
{
  Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}"); // mostrar a chave e seu valor
}
// verificar itens no dictionary
string chave = "BA";
Console.WriteLine($"Verificando o item {chave}");
Console.WriteLine(estados.ContainsKey(chave) ? "O valor existe." : "O valor não existe.");

// Tratar exceção com try-catch

try
{
  string[] linhas = File.ReadAllLines("assets/arquivoLeitura.txt");
  foreach (string linha in linhas) // fazer a leitura de um arquivo externo
  {
    Console.WriteLine(linha);
  }
}
catch (FileNotFoundException ex)
{
  // exemplo de exceção especifica:
  Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado >> {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
  // exemplo de exceção específica do diretório:
  Console.WriteLine($"Ocorreu um erro de leitura, diretório/pasta não encontrado >> {ex.Message}");
}
catch (Exception ex)
{
  // exceção genérica:
  Console.WriteLine($"Ocorreu uma exceção genérica >> {ex.Message}");
}
finally
{
  Console.WriteLine("Programa rodou e esta sendo finalizado!");
}
