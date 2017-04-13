CREATE TABLE [dbo].[ViagemCliente]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[IdCliente] INT NOT NULL, 
	[IdViagem] INT NULL, 
	[IdTransporte] INT NULL
)
