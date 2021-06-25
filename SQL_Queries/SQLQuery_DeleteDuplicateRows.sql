WITH CTE AS (
    SELECT 
        MovieId, 
        GenreId,
        row_num = ROW_NUMBER() OVER (
            PARTITION BY 
                MovieId, 
        GenreId
            ORDER BY 
                MovieId, 
        GenreId
        ) 
     FROM 
        MovieGenres
)
DELETE FROM CTE
WHERE row_num > 1;
