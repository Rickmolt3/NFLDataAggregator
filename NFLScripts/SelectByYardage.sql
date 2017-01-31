USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	gets a quarterbacks yardage based on his name

-- =============================================
CREATE PROCEDURE dbo.sp_getYardage
	@Quarterback NVARCHAR(100)
AS
SELECT DISTINCT Quarterback, sum(Yards) AS Yards
FROM QBStats_2016
WHERE Quarterback LIKE '%' + @Quarterback + '%' --or Yards >= @Yards--
GROUP BY Quarterback
