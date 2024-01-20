using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Csharp.projetos-csharp.Serialização.models
{
    // DESSERIALIZAÇÃO
    public class Venda
{
    public int Id { get; set; }

    //atributo para modificar a prop do json
    [JsonProperty("Nome_Produto")]
    public string Produto { get; set; }

    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }
    public decimal? Desconto { get; set; }
}

// SERIALIZAÇÃO
public class Venda
{
    // construtor
    // a prop Desconto pode ser um null type
    public Venda(int id, string produto, decimal preco, DateTime dataVenda, decimal? desconto)
    {
        Id = id;
        Produto = produto;
        Preco = preco;
        DataVenda = dataVenda;
        Desconto = desconto;
    }

    public int Id { get; set; }
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }
    public decimal? Desconto { get; set; }
}
}