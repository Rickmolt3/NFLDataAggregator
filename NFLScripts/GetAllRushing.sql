USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	gets all the rushing data for each row

-- =============================================
CREATE PROCEDURE dbo.sp_getRushing
	
AS
SELECT [Rank],
		[Name],
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