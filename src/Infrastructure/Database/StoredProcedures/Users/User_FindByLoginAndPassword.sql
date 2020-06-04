CREATE PROCEDURE [dbo].[User_FindByLoginAndPassword]
	@Login VARCHAR(100),
	@HashedPassword VARCHAR(4000)
AS
BEGIN

	SELECT  [Name]
           ,[Login]
           ,[HashedPassword]
           ,[CreatedAt]
           ,[UpdatedAt] FROM [dbo].[Users] WHERE [Login] = @Login and [HashedPassword] = @HashedPassword

END
