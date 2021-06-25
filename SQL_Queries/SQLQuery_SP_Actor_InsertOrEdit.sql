CREATE PROC Director_InsertOrEdit
@DirectorId int,
@FirstName varchar(50),
@LastName varchar(50),
@Nationality varchar(255),
@Birth int
AS
BEGIN
IF(@DirectorId = 0)
BEGIN

	INSERT INTO Directors(FirstName,LastName,Nationality,Birth)
	VALUES(@FirstName,@LastName,@Nationality,@Birth)

END;
ELSE
BEGIN
	UPDATE Directors
	SET FirstName = @FirstName, LastName = @LastName,
	Nationality =@Nationality, Birth = @Birth
	WHERE DirectorId = @DirectorId
END
END
