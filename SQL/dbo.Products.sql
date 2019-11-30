CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Brand] VARCHAR(50) NULL, 
    [Model] VARCHAR(50) NULL, 
    [Type] INT NOT NULL, 
    [WorkType] INT NOT NULL, 
    [Warranty] INT NULL, 
    [Price] FLOAT NULL, 
    [CreatedDate] DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, 
    [UpdatedDate] DATETIME NULL
)
