CREATE PROCEDURE [dbo].[Customer_FindById]
	@Id int 
AS
BEGIN

  SELECT     
			[Id]
		   ,[Nick]
           ,[Name]
           ,[LastName]
           ,[PhoneNumber]
           ,[Email]
           ,[Address]
           ,[City]
           ,[PostCode]
           ,[CreatedAt]
           ,[UpdatedAt] FROM [dbo].[Customers]  WHERE [Id] = @Id ORDER BY [CreatedAt] DESC
            
END
