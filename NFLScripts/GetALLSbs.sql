USE NFLDB
GO
CREATE PROCEDURE dbo.sp_getSB
	
AS
SELECT [Date],
		SB,
		Winner,
		Pts,
		Loser,
		LoserPts,
		MVP,
		Stadium,
		City,
		State
		
FROM superbowldata
