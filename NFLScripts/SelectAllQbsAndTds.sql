USE NFLDB
GO

-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Gets the quarterback and the sum of their yards, not a stored proc just a test

-- =============================================

SELECT DISTINCT Quarterback, sum(Yards)
FROM QBStats_2016
GROUP BY Quarterback
--ORDER BY SUM(Touchdown) DESC
