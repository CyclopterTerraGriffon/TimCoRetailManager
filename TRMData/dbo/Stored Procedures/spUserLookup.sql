CREATE PROCEDURE [dbo].[spUserLookup]
	@Id NVARCHAR(128) = 0
AS
BEGIN
SET NOCOUNT ON

	SELECT
		 U.[Id]
		,U.[FirstName]
		,U.[LastName]
		,U.[EmailAddress]
		,U.[CreatedDate]
	FROM dbo.[User] AS U
	WHERE U.[Id] = @Id

END

