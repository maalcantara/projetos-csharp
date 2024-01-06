usyng System;

class Pessoa
{
  private string Nome { get; }
  private int Idade { get; }
  private string Nacionalidade { get;using System;

class Pessoa
{
    public string Nome { get; }
    public int Idade { get; }
    public string Nacionalidade { get; }

    public Pessoa(string nome, int idade, string nacionalidade)
    {
        Nome = nome;
        Idade = idade;
        Nacionalidade = nacionalidade;
    }
}

class Program
{
    static void Main()
    {
      Console.WriteLine("Digite seu nome: ");
      string nome = Console.ReadLine();

      Console.WriteLine("Digite sua idade: ");
      int idade = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Digite sua nacionalidade: ");
      string nacionalidade = Console.ReadLine();

      Pessoa pessoa = new Pessoa(nome, idade, nacionalidade);

      Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Nacionalidade: {pessoa.Nacionalidade}");
    }
}
}

  public Pessoa (string nome, int idade, string nacionalidade)
  {
    Nome = nome;
    Idade = idade;
    Nacionalidade = nacionalidade;
  }
}

class Program
{
  static void Main()
  { 
    string nome = Console.ReadLine();
    int idade = Convert.ToInt32(Console.ReadLine());

    Pessoa pessoa = new Pessoa(nome, idade, nacionalidade);

    Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Nacionalidade: {pessoa.Nacionalidade}");
  }
}