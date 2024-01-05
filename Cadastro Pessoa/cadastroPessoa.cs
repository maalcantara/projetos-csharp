usyng System;

class Pessoa
{
  private string Nome { get; }
  private int Idade { get; }

  public Pessoa (string nome, int idade)
  {
    Nome = nome;
    Idade = idade;
  }
}

class Program
{
  static void Main()
  { 
    string nome = Console.ReadLine();
    int idade = Convert.ToInt32(Console.ReadLine());

    Pessoa pessoa = new Pessoa(nome, idade);

    Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
  }
}