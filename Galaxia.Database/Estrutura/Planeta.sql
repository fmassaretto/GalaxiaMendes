CREATE TABLE [dbo].[Planeta]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Descricao] VARCHAR(50) NOT NULL, 
    [PossuiOxigenio] BIT NOT NULL
)
