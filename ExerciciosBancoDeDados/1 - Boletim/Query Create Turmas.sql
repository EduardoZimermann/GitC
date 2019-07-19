CREATE TABLE [dbo].[Turmas] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Serie] VARCHAR (50) NOT NULL,
    [Sala]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

