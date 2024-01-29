-- CONSTRAINTS, FUNCTIONS E PROCEDURES

-- Constraints
ALTER TABLE Produtos
ADD UNIQUE(Nome)

ALTER TABLE Produtos
ADD CHECK(Genero = 'U' OR Genero = 'M' OR Genero = 'F')

ALTER TABLE Produtos
ADD DEFAULT GETDATE() FOR DataCadastro

-- apagando uma constraint
ALTER TABLE Produtos
DROP CONSTRAINT UQ__Produtos__7D8FE957D('nome da constraint')



-- Stored Procedures -> Procedures
CREATE PROCEDURE InserirNovoProduto
-- parâmetros que vai receber:
@Nome varchar(255),
@Cor varhar(50),
@Preco decimal,
@Tamanho varchar(5),
@Genero char(1)

AS

INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero)
-- parâmetros do método
VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero)

-- usando a procedure criada:
EXEC InserirNovoProduto
  'Novo produto procedure',
  'Colorido',
  50,
  'G',
  'U'


-- Stored Procedure com SELECT
CREATE PROCEDURE ObterProdutosTamanho
@TamanhoProduto varchar(5)

AS

SELECT * FROM Produtos WHERE Tamanho = @TamanhoProduto

-- usando:
EXEC ObterProdutosTamanho 'P'


-- outra procedure
CREATE PROCEDURE ObterTodosProdutos

AS

SELECT * FROM Produtos

-- usando:
EXEC ObterTodosProdutos



-- FUNCTIONS
CREATE FUNCTION CalcularDesconto(@Preco DECIMAL (13,2), @Porcentagem INT)
RETURNS DECIMAL(13,2)

BEGIN
  RETURN @Preco - @Preco / 100 * @Porcentagem
END

-- após executar a função, dar reload no InteliSense
-- usando: 
SELECT
  Nome,
  Preco,
  dbo.CalcularDesconto(Preco, 10) PrecoComDesconto
FROM Produtos WHERE Tamanho = 'M'