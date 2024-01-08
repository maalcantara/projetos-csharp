using System;

class Personagem
{
  public string Nome { get; set; }
  public int Mana { get; set; }

  public Personagem(string nome, int mana)
  {
    Nome = nome;
    Mana = mana;
  }
}

class Especializacoes : Personagem
{
  public int DanoBase { get; set; }

  public Especializacoes(string nome, int mana, int danoBase) : base(nome, mana)
  {
    DanoBase = danoBase;
  }

  public void CalcularDano()
  {
    Console.WriteLine($"{Nome} 🧙 atacou e causou {DanoBase * Mana} de dano! ⚔️");
  }
}

class Program
{
  static void Main()
  {
    Console.WriteLine("Digite o nome do personagem: 🧙 ");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite a mana do personagem: ⚔️");
    int mana = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor do dano: ☄️");
    int danoBase = int.Parse(Console.ReadLine());

    Especializacoes sub1 = new Especializacoes(nome, mana, danoBase);

    sub1.CalcularDano();
  }
}