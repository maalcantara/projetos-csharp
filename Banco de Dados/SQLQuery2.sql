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
CREATE PROCEDURE 