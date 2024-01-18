using Models;
using Newtonsoft.Json;

// IMPORTAR EM JSON -> DESERIALIZE OBJECT

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
  Console.WriteLine($"Id: {venda.Id},\n
                    Produto: { venda.Produto},\n
                    Preço: { venda.Preco},\n
                    Data: { venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}
  ")
}


// EXPORTAR EM JSON -> SERIALIZE OBJECT

DateTime dataAtual = DateTime.Now;

// criar um array pra adição de itens ficar + dinâmica
List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Grampeador", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);