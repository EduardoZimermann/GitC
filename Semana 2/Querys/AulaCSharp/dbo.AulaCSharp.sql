CREATE TABLE [dbo].[AulaCSharp]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Aluno] VARCHAR(100) NOT NULL, 
    [Idade] INT NULL, 
    [Ativo] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsoAlt] INT NOT NULL, 
    [DatInc] DATE NOT NULL, 
    [DatAlt] DATE NOT NULL
)
