using System;

class Robo
{
    public int VelocidadeAtual { get; private set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int velocidadeMinima, int velocidadeMaxima)
    {
        VelocidadeMinima = velocidadeMinima;
        VelocidadeMaxima = velocidadeMaxima;
        VelocidadeAtual = velocidadeMinima;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }

    public override string ToString()
    {
        return $"Velocidade Atual: {VelocidadeAtual}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a velocidade mínima e máxima (separadas por espaço): 🤖");
        string[] valores = Console.ReadLine().Split(' ');

        if (valores.Length != 2 || !int.TryParse(valores[0], out int vmin) || !int.TryParse(valores[1], out int vmax))
        {
            Console.WriteLine("Entrada inválida. Forneça dois números. (ex: '2 8')");
            return;
        }

        Robo robo = new Robo(vmin, vmax);

        Console.WriteLine("Digite os comandos (A para acelerar, D para desacelerar): ⏩");
        string comandos = Console.ReadLine();

        foreach (char comando in comandos)
        {
            if (comando == 'A')
            {
                robo.Acelerar();
            }
            else if (comando == 'D')
            {
                robo.Desacelerar();
            }
        }

        Console.WriteLine(robo);
    }
}
