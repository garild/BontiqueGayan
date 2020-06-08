CREATE PROCEDURE [dbo].[Customer_DeleteWhereId]
	@Id int 
AS
BEGIN

  DELETE [dbo].[Customers]  WHERE [Id] = @Id 
            
END

