CREATE PROCEDURE [dbo].[Customers_GetAll]
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
           ,[UpdatedAt] FROM [dbo].[Customers] ORDER BY [CreatedAt] DESC

END;
