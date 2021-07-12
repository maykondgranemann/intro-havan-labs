USE [HavanLabs]
GO
--Tables
-- Create
CREATE TABLE Categorias
(
	Id INT IDENTITY(1,1) NOT NULL
	,Nome VARCHAR(50) NOT NULL
)
-- Delete
DROP TABLE Categorias
