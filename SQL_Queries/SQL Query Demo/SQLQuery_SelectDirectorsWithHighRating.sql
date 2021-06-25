SELECT FirstName, LastName
FROM Directors
WHERE DirectorId IN (SELECT DirectorId FROM Movies WHERE Rating >=8.7);