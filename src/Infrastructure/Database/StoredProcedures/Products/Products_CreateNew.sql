CREATE PROCEDURE [dbo].[Product_CreateNew]
@Name VARCHAR(255),
@Code VARCHAR(100),
@Description VARCHAR(4000),
@GeneralSize VARCHAR(10),
@Size VARCHAR(10),
@Color VARCHAR(50),
@Image IMAGE,
@Category VARCHAR(50),
@Quantity INT
AS
BEGIN

INSERT INTO [dbo].[Products]
           ([Name]
           ,[Code]
           ,[Description]
           ,[GeneralSize]
           ,[Size]
           ,[Color]
           ,[Image]
           ,[Category]
           ,[Quantity]
           ,[CreatedAt])
     VALUES
           ( @Name, @Code, @Description, @GeneralSize, @Size, @Color, @Image, @Category, @Quantity,  GETDATE() )

      SELECT  
            [Id]
            [Name]
           ,[Code]
           ,[Description]
           ,[GeneralSize]
           ,[Size]
           ,[Color]
           ,[Image]
           ,[Category]
           ,[Quantity]
           ,[CreatedAt] FROM [dbo].[Products] WHERE [Id] = SCOPE_IDENTITY();

END
