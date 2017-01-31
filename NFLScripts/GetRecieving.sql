USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	gets all the recieving yards for each row and columns

-- =============================================
CREATE PROCEDURE dbo.sp_getRecieving
	
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
