# Orientação a Objetos com cadastro de pessoas 📋

O programa cria uma classe `Pessoa` com os atributos nome e idade. Depois há um objeto do tipo pessoa que exibe na tela os dados.

##

```
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
```

💡Primeiro são criadas as propriedades privadas (Nome e Idade) pra armazanar os valores internamente na classe.

`public Pessoa(string nome, int idade)`
depois, uso esses mesmos nomes como parâmetros do construtor para permitir forneçer valores durante a instanciação da classe.

`Pessoa pessoa = new Pessoa("Mari", 19)`
seria a instância da classe Pessoa com seus valores dados, sendo imutáveis após a criação.
