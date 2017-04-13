CREATE TABLE [dbo].[Viagem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[PlanetaOrigem] VARCHAR(50) NOT NULL, 
	[PlanetaDestino] VARCHAR(50) NOT NULL, 
	[Valor] MONEY NOT NULL, 
	[Tempo] INT NOT NULL
)
