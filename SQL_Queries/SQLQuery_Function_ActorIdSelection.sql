-- ================================================
-- Template generated from Template Explorer using:
-- Create Inline Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION ActorIdSelection
(	
	-- Add the parameters for the function here
	@LastName varchar(50)
)
RETURNS int 
AS

BEGIN
	DECLARE @ActorId int
	SELECT @ActorId = (SELECT ActorId From Actors Where LastName = @LastName)
	RETURN @ActorId
END
GO
