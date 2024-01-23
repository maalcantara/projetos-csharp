## Contexto

Você é responsável pelo banco de dados de um site de filmes, onde são armazenados dados sobre os filmes e seus atores. Sendo assim, foi solicitado para que você realize uma consulta no banco de dados com o objetivo de trazer alguns dados para análises.

## Proposta

São 12 consultas realizadas no banco de dados, cada uma retornando um tipo de informação.
O banco de dados está modelado da seguinte maneira:

<p align="center"><img src="images/diagrama.png" width=400></p>
As tabelas sao descritas conforme a seguir:

| Tabela 🗄️    | Descrição 📊                                                                                                                                                                                         |
| ------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Filmes       | Tabela responsável por armazenar informações dos filmes.                                                                                                                                             |
| Atores       | Tabela responsável por armazenar informações dos atores.                                                                                                                                             |
| Generos      | Tabela responsável por armazenar os gêneros dos filmes.                                                                                                                                              |
| ElencoFilme  | Tabela responsável por representar um relacionamento do tipo muitos para muitos entre filmes e atores, ou seja, um ator pode trabalhar em muitos filmes, e filmes podem ter muitos atores.           |
| FilmesGenero | Tabela responsável por representar um relacionamento do tipo muitos para muitos entre filmes e gêneros, ou seja, um filme pode ter mais de um gênero, e um genêro pode fazer parte de muitos filmes. |

## Queries 🔍

| Query 🔎                                                                                                         | Comandos ☝️                 |
| ---------------------------------------------------------------------------------------------------------------- | --------------------------- |
| 1. Buscar o nome e o ano do filmes                                                                               | SELECT                      |
| 2. Buscar o nome e o ano dos filmes, ordenados em ordem crescente pelo ano                                       | SELECT, WHERE e ORDER BY    |
| 3. Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração                                    | SELECT e WHERE              |
| 4. Buscar os filmes lançados em 1997                                                                             | SELECT e WHERE              |
| 5. Buscar os filmes lançados APÓS o ano 2000                                                                     | SELECT e WHERE >            |
| 6. Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente       | SELECT, WHERE e ORDER BY    |
| 7. Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duracao em ordem decrescente | SELECT, ORDER BY e GROUP BY |
| 8. Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome                                   | SELECT e WHERE              |
| 9. Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome     | SELECT, WHERE e ORDER BY    |
| 10. Buscar o nome do filme e o gênero                                                                            | SELECT e INNER JOIN         |
| 11. Buscar o nome do filme e o gênero do tipo "Mistério"                                                         | SELECT, INNER JOIN e WHERE  |
| 12. Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel                          | SELECT e INNER JOIN         |
