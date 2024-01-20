// OBJECT ****************************************************************************
object[] arrayDeObjetos = new object[] { 1, "dois", 3.0, true };

foreach (object item in arrayDeObjetos)
{
  Console.WriteLine(item);
}


// DYNAMIC ***************************************************************************
dymanic varDinamica = 4;
Console.WriteLine($"Tipo da variável: {varDinamica.GetType()}, Valor: {varDinamica}");

dymanic varDinamica = "texto";
Console.WriteLine($"Tipo da variável: {varDinamica.GetType()}, Valor: {varDinamica}");

dymanic varDinamica = true;
Console.WriteLine($"Tipo da variável: {varDinamica.GetType()}, Valor: {varDinamica}");


// VAR *******************************************************************************
var arrayDeNomes = new[] { "Nick", "Charlie", "Tao" };
// O compilador infere que 'arrayDeNomes' é do tipo string[]
foreach (var nome in arrayDeNomes)
{
  Console.WriteLine(nome);
}


// VOID *******************************************************************************
static void ExibirMensagem() // método que não retorna valor (void)
{
  Console.WriteLine("Esta é uma mensagem do método ExibirMensagem.");
}


// NULL *******************************************************************************
public Venda(string produto, decimal preco, decimal? desconto) // construtor
{
  Produto = produto;
  Preco = preco;
  Desconto = desconto;
}
public string Produto { get; set; }
public decimal Preco { get; set; }
public decimal? Desconto { get; set; }


// ANONYMOUS **************************************************************************
// deserializar com tipo anônimo
string conteudoArquivo = File.ReadAllText("arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach (var venda in listaAnonimo)
{
  Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}


// GENERIC ****************************************************************************
//-> classe genérica
MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AddElementArray(30);
Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AddElementArray("Teste");
Console.WriteLine(arrayString[0]);



// EXTENSION METHODS *******************************************************************
// classe extendida -> virou um método pra chamar no Program
public static class IntExtensions
{
  public static bool EhPar(this int num)
  {
    return num % 2 == 0;
  }
}

// Program.cs
int num = 20;
bool par = false;

par = num.EhPar();

string msg = "O número " + num + " " + "é " + (par ? "par" : "impar");
Console.WriteLine(msg);