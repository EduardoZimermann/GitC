CREATE TABLE [dbo].[Alunos] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (100) NOT NULL,
    [Idade] INT           NOT NULL,
    [Turma] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Alunos_Turma] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turmas] ([Id])
);

