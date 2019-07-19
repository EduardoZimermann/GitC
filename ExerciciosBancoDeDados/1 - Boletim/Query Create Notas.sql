CREATE TABLE [dbo].[Registros] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [Aluno] INT NOT NULL,
    [Nota] FLOAT NOT NULL,
    [Presente] BIT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Registros_Aluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

