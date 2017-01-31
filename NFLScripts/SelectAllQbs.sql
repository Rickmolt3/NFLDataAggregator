USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Gets all quarterback data and performs calculations on all data columns

-- =============================================
CREATE PROCEDURE dbo.sp_getAllQbs
	
AS
SELECT DISTINCT Quarterback, 
				SUM(Attempt) AS Attempts, 
				SUM(Completion) AS Completions, 
				SUM(Yards) AS Yards , 
				AVG(YardsPerAttempt) AS YPAttempt, 
				SUM(Touchdown) AS Touchdowns,
				SUM(Interception) AS Interceptions,
				MAX(Long) AS Longest,
				MAX(Sack) AS Sacks,
				AVG(Loss) AS Loss,
				AVG(Rate) AS Rate,
				SUM(TotalPoints) AS TotalPoints
FROM QBStats_2016
GROUP BY Quarterback