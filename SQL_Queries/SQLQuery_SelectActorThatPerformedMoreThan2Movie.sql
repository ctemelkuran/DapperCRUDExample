SELECT    DISTINCT    dbo.Actors.FirstName, dbo.Actors.LastName
FROM            dbo.Actors INNER JOIN
                         dbo.MovieActors ON dbo.Actors.ActorId = dbo.MovieActors.ActorId INNER JOIN
                         dbo.Movies ON dbo.MovieActors.MovieId = dbo.Movies.Id
WHERE Actors.ActorId IN (Select ActorId FROM MovieActors GROUP BY ActorId HAVING COUNT(*)>=2)
