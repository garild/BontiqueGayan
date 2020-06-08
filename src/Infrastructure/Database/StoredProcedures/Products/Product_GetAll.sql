CREATE PROCEDURE [dbo].[Product_GetAll]
AS
BEGIN
	 SELECT [Name]
           ,[Code]
           ,[Description]
           ,[GeneralSize]
           ,[Size]
           ,[Color]
           ,[Image]
           ,[Category]
           ,[Quantity]
           ,[CreatedAt]
           ,[UpdatedAt] FROM [dbo].[Products]
END
