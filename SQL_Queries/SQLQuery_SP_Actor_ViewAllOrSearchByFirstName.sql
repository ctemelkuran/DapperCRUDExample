CREATE PROC Actor_ViewAllOrSearchByFirstName
@SearchText VARCHAR(255)
AS
BEGIN

SELECT *
FROM Actors
WHERE @SearchText='' OR FirstName LIKE '%'+@SearchText+'%'

END