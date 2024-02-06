# Entity Framework (EF) 🔮

**É uma Framework ORM (Object-Relational Mapping) criado para facilitar a integração com o banco de dados, mapeando tabelas e gerando comandos SQL de forma automática.**

<p align="center"><img src="images/entityframework.png" width="200"></p>

**UI - User Interface:** pode ser uma tela de cadastro, API, etc. É a tela de interação com o usuário.

**Bussines Layer:** 'Negócios' que podem ser as classes ou contollers. É tudo que faz acesso ao processamento, onde recebe os dados.

**Date Layer:** Camada mais próxima ao banco de dados. Onde está o _Entity Framework_ → responsável por se comunicar com o db e gerar a linguagem SQL.

- Ex: uma classe chamada Clientes em C# e uma tabela chamada Clientes no banco de dados.

Para persistir(armazenar/salvar) dados de um programa C# para um banco de dados deve-se realizar a comunicação da mesma língua do Banco de Dados (SQL).

⏺️ Ex: quero salvar um usuário
