USE [MovieDatabase]
GO
/****** Object:  StoredProcedure [dbo].[Actor_ViewAllOrSearchByFirstName]    Script Date: 24/06/2021 11:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Actor_ViewAllOrSearchByFirstName]
@SearchText VARCHAR(255)
AS
BEGIN

SELECT *
FROM Actors
WHERE @SearchText='' OR CONCAT(FirstName,' ',LastName) LIKE '%'+@SearchText+'%'

END