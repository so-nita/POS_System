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

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [Category] (
        [Id] varchar(36) NOT NULL,
        [Name] varchar(100) NOT NULL,
        [Image] varchar(550) NULL,
        [Description] varchar(255) NULL,
        [Create_At] datetime NOT NULL,
        [Status] int NOT NULL,
        [Is_Deleted] bit NOT NULL,
        CONSTRAINT [PK_Category] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [Roles] (
        [Id] varchar(36) NOT NULL,
        [Name] varchar(100) NOT NULL,
        [Description] varchar(255) NULL,
        [Create_At] datetime NOT NULL,
        [Status] int NOT NULL,
        [Is_Deleted] bit NULL,
        CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [Section] (
        [Id] varchar(36) NOT NULL,
        [Name] varchar(100) NOT NULL,
        [Desctiption] nvarchar(255) NULL,
        [Status] int NOT NULL,
        [Create_At] datetime NOT NULL,
        [Is_Deleted] bit NOT NULL,
        CONSTRAINT [PK_Section] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [SystemTypes] (
        [Id] varchar(36) NOT NULL,
        [Name] varchar(100) NOT NULL,
        [Create_At] datetime NOT NULL,
        [Status] int NOT NULL,
        [Is_Deleted] bit NULL,
        CONSTRAINT [PK_SystemTypes] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [SubCategories] (
        [Id] varchar(36) NOT NULL,
        [Name] varchar(100) NOT NULL,
        [Image] varchar(550) NULL,
        [Main_Category_Id] varchar(36) NOT NULL,
        [Description] varchar(255) NULL,
        [Create_At] datetime NOT NULL,
        [Status] int NOT NULL,
        [Is_Deleted] bit NOT NULL,
        CONSTRAINT [PK_SubCategories] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_SubCategories_Category_Main_Category_Id] FOREIGN KEY ([Main_Category_Id]) REFERENCES [Category] ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [Companies] (
        [Id] varchar(36) NOT NULL,
        [Name] varchar(100) NOT NULL,
        [NameKh] varchar(100) NULL,
        [Email] varchar(100) NULL,
        [Contact] varchar(12) NOT NULL,
        [System_Id] varchar(36) NOT NULL,
        [Image] varchar(500) NULL,
        [Website] varchar(255) NULL,
        [Address] varchar(255) NOT NULL,
        [Create_At] datetime NOT NULL,
        [Status] int NOT NULL,
        [Is_Deleted] bit NULL,
        CONSTRAINT [PK_Companies] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Companies_SystemTypes_System_Id] FOREIGN KEY ([System_Id]) REFERENCES [SystemTypes] ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [Users] (
        [Id] varchar(36) NOT NULL,
        [UserName] varchar(50) NOT NULL,
        [Name] varchar(100) NOT NULL,
        [Gender] int NULL,
        [Email] varchar(100) NULL,
        [Password] varchar(50) NOT NULL,
        [Contact] varchar(12) NOT NULL,
        [Image] varchar(550) NULL,
        [Company_Id] varchar(36) NOT NULL,
        [Role_Id] varchar(36) NOT NULL,
        [Address] nvarchar(550) NULL,
        [Create_At] datetime NOT NULL,
        [Status] int NOT NULL,
        [Is_Deleted] bit NOT NULL,
        [Token] nvarchar(550) NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Users_Companies_Company_Id] FOREIGN KEY ([Company_Id]) REFERENCES [Companies] ([Id]),
        CONSTRAINT [FK_Users_Roles_Role_Id] FOREIGN KEY ([Role_Id]) REFERENCES [Roles] ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [Orders] (
        [Id] varchar(36) NOT NULL,
        [Sub_Total] decimal(8,2) NOT NULL,
        [Total_Discount] decimal(8,2) NOT NULL,
        [Total] decimal(8,2) NOT NULL,
        [Total_Item] int NOT NULL,
        [Company_Id] varchar(36) NULL,
        [Section_Id] varchar(36) NULL,
        [Reference_Id] varchar(36) NULL,
        [Order_Date] datetime NOT NULL,
        [Order_Status] int NOT NULL,
        [Is_Delete] bit NOT NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Orders_Section_Section_Id] FOREIGN KEY ([Section_Id]) REFERENCES [Section] ([Id]),
        CONSTRAINT [FK_Orders_Users_Reference_Id] FOREIGN KEY ([Reference_Id]) REFERENCES [Users] ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [Products] (
        [Id] varchar(36) NOT NULL,
        [Code] varchar(36) NOT NULL,
        [Name] varchar(100) NOT NULL,
        [NameKh] nvarchar(255) NULL,
        [Create_By] varchar(36) NOT NULL,
        [Company_Id] varchar(36) NOT NULL,
        [Company_Name] varchar(100) NOT NULL,
        [Category_Id] varchar(36) NOT NULL,
        [Image] varchar(550) NULL,
        [Cost] decimal(8,2) NOT NULL,
        [Price] decimal(8,2) NOT NULL,
        [Description] varchar(255) NULL,
        [Create_At] datetime NOT NULL,
        [Last_Update] datetime NULL,
        [Status] int NOT NULL,
        [Is_Deleted] bit NOT NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Products_SubCategories_Category_Id] FOREIGN KEY ([Category_Id]) REFERENCES [SubCategories] ([Id]),
        CONSTRAINT [FK_Products_Users_Create_By] FOREIGN KEY ([Create_By]) REFERENCES [Users] ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [User_Logs] (
        [Id] varchar(36) NOT NULL,
        [User_Id] varchar(36) NOT NULL,
        [User_Name] varchar(100) NOT NULL,
        [User_Type] varchar(100) NOT NULL,
        [Action] int NOT NULL,
        [Create_At] datetime NOT NULL,
        CONSTRAINT [PK_User_Logs] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_User_Logs_Users_User_Id] FOREIGN KEY ([User_Id]) REFERENCES [Users] ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [Receipts] (
        [Id] varchar(36) NOT NULL,
        [Order_Id] varchar(36) NULL,
        [Discount] decimal(8,2) NOT NULL,
        [Total] decimal(8,2) NOT NULL,
        [Reference] varchar(36) NULL,
        [Transaction_Date] datetime NOT NULL,
        CONSTRAINT [PK_Receipts] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Receipts_Orders_Order_Id] FOREIGN KEY ([Order_Id]) REFERENCES [Orders] ([Id]),
        CONSTRAINT [FK_Receipts_Users_Reference] FOREIGN KEY ([Reference]) REFERENCES [Users] ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE TABLE [OrderDetails] (
        [Id] varchar(36) NOT NULL,
        [Product_Id] varchar(36) NOT NULL,
        [Order_Id] varchar(36) NOT NULL,
        [Product_Name] varchar(100) NOT NULL,
        [Size] varchar(100) NULL,
        [Price] decimal(8,2) NOT NULL,
        [Qty] int NOT NULL,
        [Discount] decimal(8,2) NULL,
        [SubTotal] decimal(8,2) NOT NULL,
        [Tax] decimal(8,2) NULL,
        [Total] decimal(8,2) NOT NULL,
        [Create_At] datetime NOT NULL,
        CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_OrderDetails_Orders_Order_Id] FOREIGN KEY ([Order_Id]) REFERENCES [Orders] ([Id]),
        CONSTRAINT [FK_OrderDetails_Products_Product_Id] FOREIGN KEY ([Product_Id]) REFERENCES [Products] ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE UNIQUE INDEX [IX_Category_Name] ON [Category] ([Name]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_Companies_System_Id] ON [Companies] ([System_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_OrderDetails_Order_Id] ON [OrderDetails] ([Order_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_OrderDetails_Product_Id] ON [OrderDetails] ([Product_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_Orders_Reference_Id] ON [Orders] ([Reference_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_Orders_Section_Id] ON [Orders] ([Section_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_Products_Category_Id] ON [Products] ([Category_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE UNIQUE INDEX [IX_Products_Code] ON [Products] ([Code]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_Products_Create_By] ON [Products] ([Create_By]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_Receipts_Order_Id] ON [Receipts] ([Order_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_Receipts_Reference] ON [Receipts] ([Reference]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_SubCategories_Main_Category_Id] ON [SubCategories] ([Main_Category_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE UNIQUE INDEX [IX_SubCategories_Name] ON [SubCategories] ([Name]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_User_Logs_User_Id] ON [User_Logs] ([User_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_Users_Company_Id] ON [Users] ([Company_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE INDEX [IX_Users_Role_Id] ON [Users] ([Role_Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    CREATE UNIQUE INDEX [IX_Users_UserName] ON [Users] ([UserName]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219081921_M_1'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231219081921_M_1', N'8.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231227094258_M_2'
)
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'Password');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Users] ALTER COLUMN [Password] varchar(100) NOT NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231227094258_M_2'
)
BEGIN
    ALTER TABLE [Products] ADD [Qty] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231227094258_M_2'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231227094258_M_2', N'8.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228043024_M2'
)
BEGIN
    ALTER TABLE [Orders] DROP CONSTRAINT [FK_Orders_Section_Section_Id];
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228043024_M2'
)
BEGIN
    DROP TABLE [Section];
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228043024_M2'
)
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'Total_Item');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Orders] DROP COLUMN [Total_Item];
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228043024_M2'
)
BEGIN
    EXEC sp_rename N'[Orders].[Section_Id]', N'Source_Id', N'COLUMN';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228043024_M2'
)
BEGIN
    EXEC sp_rename N'[Orders].[IX_Orders_Section_Id]', N'IX_Orders_Source_Id', N'INDEX';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228043024_M2'
)
BEGIN
    CREATE TABLE [Sources] (
        [Id] varchar(36) NOT NULL,
        [Name] varchar(100) NOT NULL,
        [Desctiption] nvarchar(255) NULL,
        [Status] int NOT NULL,
        [Create_At] datetime NOT NULL,
        [Is_Deleted] bit NOT NULL,
        CONSTRAINT [PK_Sources] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228043024_M2'
)
BEGIN
    ALTER TABLE [Orders] ADD CONSTRAINT [FK_Orders_Sources_Source_Id] FOREIGN KEY ([Source_Id]) REFERENCES [Sources] ([Id]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228043024_M2'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231228043024_M2', N'8.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228063949_M_3'
)
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[OrderDetails]') AND [c].[name] = N'Tax');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [OrderDetails] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [OrderDetails] DROP COLUMN [Tax];
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228063949_M_3'
)
BEGIN
    ALTER TABLE [Products] ADD [Size] varchar(255) NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228063949_M_3'
)
BEGIN
    ALTER TABLE [Orders] ADD [Tax] decimal(8,2) NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228063949_M_3'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231228063949_M_3', N'8.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228074415_M-4'
)
BEGIN
    EXEC sp_rename N'[Orders].[Total]', N'Grand_Total', N'COLUMN';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228074415_M-4'
)
BEGIN
    EXEC sp_rename N'[OrderDetails].[Total]', N'Sub_Amount', N'COLUMN';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228074415_M-4'
)
BEGIN
    EXEC sp_rename N'[OrderDetails].[SubTotal]', N'Grand_Amount', N'COLUMN';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228074415_M-4'
)
BEGIN
    EXEC sp_rename N'[OrderDetails].[Discount]', N'Discount_Percent', N'COLUMN';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228074415_M-4'
)
BEGIN
    ALTER TABLE [OrderDetails] ADD [Discount_Amount] decimal(8,2) NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231228074415_M-4'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231228074415_M-4', N'8.0.0');
END;
GO

COMMIT;
GO

