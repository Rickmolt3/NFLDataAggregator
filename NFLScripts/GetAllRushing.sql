USE NFLDB
GO
CREATE PROCEDURE dbo.sp_getRushing
	
AS
SELECT [Rank],
		Name,
		Team,
		Age,
		Position,
		Games,
		GamesStarted,
		RushAttempts,
		RushYds,
		RushTD,
		RushLng,
		RushYA,
		RushYG,
		RushAG,
		ScrimageYds,
		TotalTds,
		Fumble
		
FROM runningbackdata