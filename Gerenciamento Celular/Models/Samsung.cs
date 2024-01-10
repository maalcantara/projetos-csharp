using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp.projetos-csharp.Gerenciamento Celular.Models
{
    public class Samsung : Smartphone
{
    public Samsung(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

    public override void InstalarAplicativo(string nomeApp, string modelo)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no Samsung {modelo}...");
    }
}
}