-- 1. Buscar o nome e ano dos filmes
SELECT Nome, Ano FROM Filmes


-- 2. Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano
SELECT Nome, Ano FROM Filmes ORDER BY Ano 


-- 3. Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a dura��o
SELECT * FROM Filmes
WHERE Nome = 'De Volta para o Futuro'


-- 4. Buscar os filmes lan�ados em 1997
SELECT * FROM Filmes
WHERE Ano = 1997


-- 5. Buscar os filmes lan�ados AP�S o ano 2000
SELECT * FROM Filmes 
WHERE Ano > 2000


-- 6. Buscar os filmes com a dura��o maior que 100 e menor que 150, ordenando pela dura��o em ordem crescente
SELECT * FROM Filmes
WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao

-- 7. Buscar a quantidade de filmes lan�ados no ano, agrupando por ano, ordenando pela dura��o em ordem decrescente
SELECT Ano, COUNT(*) Quantidade FROM Filmes
GROUP BY Ano 
ORDER BY Quantidade Desc

-- 8. Buscar os atores do g�nero masculino, retornando o PrimeiroNome e UltimoNome
SELECT PrimeiroNome, UltimoNome, Genero FROM Atores
WHERE Genero = 'M'


--9. Buscar os atores do g�nero feminino, retornando o PrimeiroNome, UltimoNome e ordenando pelo PrimeiroNome
SELECT * FROM Atores WHERE Genero = 'F'
ORDER BY PrimeiroNome

-- 10. Buscar o nome do filme e o g�nero
SELECT
	Filmes.Nome,
	Generos.Genero
FROM 
	FilmesGenero
INNER JOIN Filmes ON FilmesGenero.IdFilme = Filmes.Id
INNER JOIN Generos ON FilmesGenero.IdGenero = Generos.Id


-- 11. Buscar o nome do filme e o g�nero do tipo 'Mist�rio
SELECT
	Filmes.Nome,
	Generos.Genero
FROM 
	FilmesGenero
INNER JOIN Filmes ON FilmesGenero.IdFilme = Filmes.Id
INNER JOIN Generos ON FilmesGenero.IdGenero = Generos.Id
WHERE Genero = 'Mist�rio'


-- 12. Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel
SELECT
	Filmes.Nome,
	Atores.PrimeiroNome,
	Atores.UltimoNome,
	ElencoFilme.Papel
FROM
	ElencoFilme
INNER JOIN Filmes ON ElencoFilme.IdFilme = Filmes.Id
INNER JOIN Atores ON ElencoFilme.Id = Atores.Id
INNER JOIN Generos ON ElencoFilme.Id = Generos.Id