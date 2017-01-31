USE NFLDB
GO
ALTER PROCEDURE dbo.sp_getRecieving
	
AS
SELECT 
		[Rank],
		Player,
		Position,
		Team,
		Receptions,
		Targets,
		Yards,
		Average,
		TD,
		LONG,
		[20+],
		YardsAGame,
		Fumble,
		YardsAfterCatch,
		FirstDowns

FROM recievingdata
