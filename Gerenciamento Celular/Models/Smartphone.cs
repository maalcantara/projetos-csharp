using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp.projetos-csharp.Gerenciamento Celular.Models
{
    public class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    private string IMEI { get; set; }
    private int Memoria { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando... 📞");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação... 🔈");
    }

    public abstract void InstalarAplicativo(string nomeApp, string modelo);
}
}