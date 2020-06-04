CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(255) NOT NULL,
	[Login] VARCHAR(255) NOT NULL,
	[HashedPassword] VARCHAR(4000) NOT NULL,
	[CreatedAt] DateTime2(2) DEFAULT(GETDATE()) NOT NULL, 
    [UpdatedAt] DateTime2(2)  

	CONSTRAINT [PK_User_Id] PRIMARY KEY CLUSTERED  ([Id] DESC)

)ON [FG_PrimaryKey]

GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_Login] ON [dbo].[Users] ([Login] DESC) ON [FG_IDX]

GO