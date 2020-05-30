CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL,
	[Login] VARCHAR(50) NOT NULL,
	[HashedPassword] VARCHAR(250) NOT NULL,
	[CreatedAt] DateTime2(2) DEFAULT(GETDATE()), 
    [UpdatedAt] DateTime2(2)  

)
