USE NFLDB
GO
ALTER PROCEDURE dbo.sp_getAllQbs
	
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