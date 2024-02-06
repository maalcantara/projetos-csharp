# Entity Framework Core (EF) 🔮

**É uma Framework ORM (Object-Relational Mapping) criado para facilitar a integração com o banco de dados, mapeando tabelas e gerando comandos SQL de forma automática.**

<p align="center"><img src="images/entityframework.png" width="200"></p>

**UI - User Interface:** pode ser uma tela de cadastro, API, etc. É a tela de interação com o usuário.

**Bussines Layer:** 'Negócios' que podem ser as classes ou contollers. É tudo que faz acesso ao processamento, onde recebe os dados.

**Date Layer:** Camada mais próxima ao banco de dados. Onde está o _Entity Framework_ → responsável por se comunicar com o db e gerar a linguagem SQL.

- Ex: uma classe chamada Clientes em C# e uma tabela chamada Clientes no banco de dados.

Para persistir(armazenar/salvar) dados de um programa C# para um banco de dados deve-se realizar a comunicação da mesma língua do Banco de Dados (SQL).

⏺️ É necessario definir modelos de dados (entidades) no programa C#, as quais representam as tabelas do banco de dados. O EF cria automaticamente as consultas SQL necessárias para realizar operações **CRUD** (Create, Read, Update, Delete) no banco de dados.

## Instalação do Entity Framework Core 📥

🚨 **Importante instalar a ferramente para uso do EF:** comando `dotnet tool instal --global dotnet-ef` no terminal (essa intalação é fixa para poder usar em todos os projetos).

- Você pode invocar a ferramenta usando o comando a seguir: `dotnet-ef`
  A ferramenta 'dotnet-ef' (versão '8.0.1') foi instalada com êxito.

📦 **Pacote Entity Framework:** `dotnet add package Microsoft.EntityFrameworkCore.Design`.

📦 **Pacote SQL Server:** `dotnet add package Microsoft.EnityFrameworkCore.SqlServer`

## Exemplo de uso do Entity Framework para salvar um usuário no banco de dados:

1. Defina uma entidade para representar o usuário no código C#:

```
public class User
{
  public int Id { get; set; }
  public string Nome { get; set; }
}
```

2. Configurar um contexto do Entity Framework que represente a conexão com o banco de dados:

**Context:** uma classe que centraliza todas as informações em determinado banco de dados.

```
publlic class MyContext : DbContext
{
  public DbSet<User> Users { get; set; }

  public MyContext(DbContext<MyContext> options) : base(options)
  {

  }
}
```

`DbSet<User>` porque a classe Users está sendo representada dentro de um objeto e será uma tabela no banco de dados. Assim, é uma **entidade/entity**

`public MyContext(DbContext<MyContext> options) : base(options)` O Context faz a ligação com o banco de dados, primeiro ele recebe uma configuração, passa para a classe pai (DbContext) com ':' e representa uma tabela com o DbSet.

3. Usar o contexto para adicionar um novo usuário ao banco de dados:

```
class Program
{
  static void Main()
  {
    using (var context = new MyContext())
    {
      var newUser = new User { Nome = "Mariana" };

      context.Users.Add(newUser);
      context.SaveChanges();
    }
  }
}
```

🟣 Essa é uma maneira simplificada de usar o EF para persistir dados em um banco de dados SQL Server usando C#. É importante ajustar a string de conexão SQL de acordo com o ambiente, e configurar corretamente o Entity Framework.

## Documentação 📄

https://learn.microsoft.com/pt-br/ef/core/get-started/overview/install
