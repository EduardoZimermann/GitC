CREATE TABLE [dbo].[Usuarios] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (100) NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [DatAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Clientes] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (100) NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [DatAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Clientes_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Clientes_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id])
);

CREATE TABLE [dbo].[Carros] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Marca]  VARCHAR (50) NOT NULL,
    [Modelo] VARCHAR (50) NOT NULL,
    [Ano]    INT          NOT NULL,
    [Preco]  MONEY        NOT NULL,
    [UsuInc] INT          NOT NULL,
    [UsuAlt] INT          NOT NULL,
    [DatInc] DATETIME     NOT NULL,
    [DatAlt] DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Carros_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Carros_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id])
);

CREATE TABLE [dbo].[Estoque] (
    [Carro]      INT NOT NULL,
    [Quantidade] INT NOT NULL,
    CONSTRAINT [FK_Estoque_Carros] FOREIGN KEY ([Carro]) REFERENCES [dbo].[Carros] ([Id])
);

CREATE TABLE [dbo].[Locacoes] (
    [Id]      INT      IDENTITY (1, 1) NOT NULL,
    [Carro]   INT      NOT NULL,
    [Cliente] INT      NOT NULL,
    [DatLoc]  DATETIME DEFAULT (getdate()) NOT NULL,
    [UsuInc]  INT      NOT NULL,
    [UsuAlt]  INT      NOT NULL,
    [DatInc]  DATETIME NOT NULL,
    [DatAlt]  DATETIME NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Locacoes_Clientes] FOREIGN KEY ([Cliente]) REFERENCES [dbo].[Clientes] ([Id]),
    CONSTRAINT [FK_Locacoes_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Locacoes_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Locacoes_Carros] FOREIGN KEY ([Carro]) REFERENCES [dbo].[Carros] ([Id])
);
