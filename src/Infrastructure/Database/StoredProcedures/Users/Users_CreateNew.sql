CREATE PROCEDURE [dbo].[Users_CreateNew]
	@Login VARCHAR(100),
	@Name VARCHAR(100),
	@HashedPassword VARCHAR(4000)
AS
BEGIN

	INSERT INTO [dbo].[Users]([Login],[Name],[HashedPassword],[CreatedAt])
	VALUES (@Login , @Name , @HashedPassword , GETDATE())

	SELECT SCOPE_IDENTITY()

END
