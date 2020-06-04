CREATE TABLE [dbo].[Customers]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Nick] VARCHAR(255) NOT NULL,
	[Name] VARCHAR(255) NOT NULL,
	[LastName] VARCHAR(255) NOT NULL,
	[PhoneNumber] VARCHAR(12) NOT NULL,
	[Email] VARCHAR(50) NOT NULL,
	[Address] VARCHAR(255) NOT NULL,
	[City] VARCHAR(255) NOT NULL,
	[PostCode] VARCHAR(50) NOT NULL,
	[CreatedAt] DateTime2(2) DEFAULT(GETDATE()) NOT NULL, 
    [UpdatedAt] DateTime2(2)  

	CONSTRAINT [PK_Customer_Id] PRIMARY KEY CLUSTERED  ([Id] DESC), 

)ON [FG_PrimaryKey]

GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_Customer_Name_LastName] ON [dbo].[Customers] ([Name] DESC,[LastName] DESC) ON [FG_IDX]

GO


CREATE UNIQUE NONCLUSTERED INDEX [IX_Customer_Nick] ON [dbo].[Customers] ([Nick] DESC) ON [FG_IDX]

GO