CREATE TABLE Product
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Category] VARCHAR(50) NULL, 
    [Description] VARCHAR(150) NULL, 
    [Price] MONEY NULL, 
    [Stock] INT NULL
)
