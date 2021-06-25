SELECT FirstName, LastName, 2021 - Birth
FROM Actors
WHERE ActorId IN (SELECT ActorId FROM MovieActors WHERE MovieId IN 
(SELECT Id FROM Movies WHERE ReleaseYear > 1980))
ORDER BY Birth
