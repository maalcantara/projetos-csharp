// leitura arquivo txt com trecho de 'Hello You' - Arctic Monkeys
new ExemploExcessao().Method1();
try
{
  string[] linhas = File.ReadAllLines("Ler-Arquivo/arquivoLeitura.txt");

  foreach (string linha in linhas)
  {
    Console.WriteLine(linha);
  }
}
catch (FileNotFoundException ex)
{
  Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
catch (Exception ex)
{
  Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}");
}