Create PROCEDURE [dbo].[Customers_CreateNew]
	 @Nick VARCHAR(255)
	,@Name VARCHAR(255)
	,@LastName VARCHAR(255)
	,@PhoneNumber VARCHAR(12)
	,@Email  VARCHAR(50)
	,@Address VARCHAR(255)
	,@City VARCHAR(255)
	,@PostCode VARCHAR(50)
AS
BEGIN
	
INSERT INTO [dbo].[Customers]
           ([Nick]
           ,[Name]
           ,[LastName]
           ,[PhoneNumber]
           ,[Email]
           ,[Address]
           ,[City]
           ,[PostCode]
           ,[CreatedAt])

     VALUES
           (@Nick, @Name, @LastName, @PhoneNumber, @Email, @Address, @City , @PostCode , GETDATE() )

DECLARE @ID INT = SCOPE_IDENTITY()

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
           ,[UpdatedAt] FROM [dbo].[Customers] WHERE [Id] = @ID

END