CREATE TABLE [dbo].Supplier
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [PhoneNumber] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Address] VARCHAR(50) NULL, 
    [PostalCode] VARCHAR(50) NULL, 
    [City] VARCHAR(50) NULL, 
    [Country] VARCHAR(50) NULL, 
    [Quantity] INT NULL, 
    [Price] FLOAT NULL, 
    [ProductId] INT NULL FOREIGN KEY REFERENCES Product(Id)
)
