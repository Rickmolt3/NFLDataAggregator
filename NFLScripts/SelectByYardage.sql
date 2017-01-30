USE NFLDB
GO
ALTER PROCEDURE dbo.sp_getYardage
	@Quarterback NVARCHAR(100)
AS
SELECT DISTINCT Quarterback, sum(Yards) AS Yards
FROM QBStats_2016
WHERE Quarterback LIKE '%' + @Quarterback + '%' --or Yards >= @Yards--
GROUP BY Quarterback
