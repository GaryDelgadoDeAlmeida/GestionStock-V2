CREATE TABLE [dbo].Client (
    [Id]          INT          NOT NULL,
    [FirstName]   VARCHAR (50) NULL,
    [LastName]    VARCHAR (50) NULL,
    [PhoneNumber] VARCHAR (50) NULL,
    [Email]       VARCHAR (50) NULL,
    [Address]     VARCHAR (50) NULL,
    [PostalCode]  VARCHAR (5)  NULL,
    [City]        VARCHAR (50) NULL,
    [Country]     VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

