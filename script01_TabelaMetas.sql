IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_Metas] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Meta] nvarchar(max) NOT NULL,
    [Valor] real NOT NULL,
    [Tempo] real NOT NULL,
    [Urgencia] nvarchar(max) NOT NULL,
    [Classe] int NOT NULL,
    CONSTRAINT [PK_TB_Metas] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Meta', N'Nome', N'Tempo', N'Urgencia', N'Valor') AND [object_id] = OBJECT_ID(N'[TB_Metas]'))
    SET IDENTITY_INSERT [TB_Metas] ON;
INSERT INTO [TB_Metas] ([Id], [Classe], [Meta], [Nome], [Tempo], [Urgencia], [Valor])
VALUES (1, 0, N'Compra uma moto', N'Luiz', CAST(2 AS real), N'baixa', CAST(10000 AS real)),
(2, 0, N'Compra uma casa', N'Asteris', CAST(20 AS real), N'baixa', CAST(400000 AS real)),
(3, 0, N'Compra um vestido', N'Elizabete', CAST(1 AS real), N'alta', CAST(400 AS real)),
(4, 0, N'Compra uma TV', N'Rafael', CAST(1 AS real), N'alta', CAST(2000 AS real));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Meta', N'Nome', N'Tempo', N'Urgencia', N'Valor') AND [object_id] = OBJECT_ID(N'[TB_Metas]'))
    SET IDENTITY_INSERT [TB_Metas] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240429143105_InitialCreate', N'8.0.4');
GO

COMMIT;
GO

