SELECT TOP(5) Title
FROM Movies
WHERE Id IN (SELECT MovieId 
FROM MovieActors 
JOIN Actors ON MovieActors.ActorId = Actors.ActorId 
WHERE Actors.FirstName ='Leonardo' AND Actors.LastName = 'Dicaprio')
ORDER BY Rating DESC;