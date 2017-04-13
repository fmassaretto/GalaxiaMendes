CREATE TABLE [dbo].[Cliente]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Nome] VARCHAR(50) NOT NULL, 
	[Especie] VARCHAR(50) NOT NULL, 
	[Documento] VARCHAR(50) NOT NULL, 
	[Cor] VARCHAR(50) NOT NULL, 
	[QtdBracos] INT NOT NULL, 
	[QtdPernas] INT NOT NULL, 
	[QtdCabecas] INT NOT NULL, 
	[Respira] BIT NOT NULL
)
