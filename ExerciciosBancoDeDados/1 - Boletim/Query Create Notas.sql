CREATE TABLE [dbo].[Registros] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [Aluno] INT NOT NULL,
    [Nota1] INT NULL,
    [Nota2] INT NULL,
    [Nota3] INT NULL,
    [Nota4] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Registros_Aluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

