USE NFLDB
GO

--SELECT DISTINCT GROUP BY ASC Quarterback,SUM(Touchdown),SUM(Interception)
--FROM QBStats_2016


SELECT DISTINCT Quarterback, sum(Touchdown),SUM(Interception)
FROM QBStats_2016
GROUP BY Quarterback
ORDER BY SUM(Touchdown) DESC
