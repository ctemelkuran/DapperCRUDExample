CREATE PROC Actor_DeleteById
@ActorId int
AS BEGIN
DELETE FROM Actors
WHERE ActorId = @ActorId
END