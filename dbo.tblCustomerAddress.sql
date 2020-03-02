CREATE TABLE [dbo].[tblCustomer] (
    [Customer ID] INT        IDENTITY (1, 1) NOT NULL,
    [Address] VARCHAR(50) NOT NULL, 
    [FullName] VARCHAR(50) NOT NULL, 
    [DOB] VARCHAR(30) NOT NULL, 
    [Member] BIT NOT NULL, 
    [Email] VARCHAR(30) NOT NULL, 
    [Card Number] VARCHAR(19) NOT NULL, 
    [Sort Code] VARCHAR(8) NOT NULL, 
    CONSTRAINT [PK tblCustomer] PRIMARY KEY CLUSTERED ([Customer ID] ASC)
);

