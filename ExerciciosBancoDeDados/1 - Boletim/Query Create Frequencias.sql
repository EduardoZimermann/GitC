CREATE TABLE [dbo].[Frequencias] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [Aluno] INT NOT NULL,
    [Dia1]  FLOAT NULL,
    [Dia2]  FLOAT NULL,
    [Dia3]  FLOAT NULL,
    [Dia4]  FLOAT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Frequencias_Aluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

