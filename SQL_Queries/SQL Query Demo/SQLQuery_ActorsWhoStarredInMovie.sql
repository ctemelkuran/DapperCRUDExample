SELECT FirstName, LastName
FROM Actors
WHERE ActorId IN (SELECT ActorId FROM MovieActors WHERE MovieId = 
(SELECT Id FROM Movies WHERE Title = 'Fight Club'));