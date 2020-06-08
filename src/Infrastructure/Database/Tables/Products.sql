CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(255) NOT NULL,
	[ShortName] VARCHAR(100) NOT NULL,
	[Description] VARCHAR(4000) NOT NULL,
	[GeneralSize] VARCHAR(10) NOT NULL,
	[Size] VARCHAR(10) NOT NULL,
	[Color] VARCHAR(100) NOT NULL,
	[Image] IMAGE NOT NULL,
	[Category] VARCHAR(50) NOT NULL,
    [Quantity] INT NOT NULL,
	[CreatedAt] DateTime2(2) DEFAULT(GETDATE()) NOT NULL, 
    [UpdatedAt] DateTime2(2)  
	
	CONSTRAINT [PK_Product_Id] PRIMARY KEY CLUSTERED  ([Id] DESC), 

)ON [FG_PrimaryKey]

