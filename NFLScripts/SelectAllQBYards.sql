USE NFLDB
GO
CREATE PROCEDURE dbo.sp_getAllYardage
	
AS
SELECT DISTINCT Quarterback, sum(Yards) AS Yards
FROM QBStats_2016
GROUP BY Quarterback