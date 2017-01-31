USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/6/2017
-- Description:	Gets all distinct quarterbacks and their sum yardage from the db

-- =============================================
CREATE PROCEDURE dbo.sp_getAllYardage
	--no parameters just gets all distinct qbs
AS
SELECT DISTINCT Quarterback, sum(Yards) AS Yards
FROM QBStats_2016
GROUP BY Quarterback