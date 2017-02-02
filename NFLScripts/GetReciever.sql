USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 2/2/2017
-- Description:	Gets the reciever by the name 

-- =============================================
CREATE PROCEDURE dbo.sp_GetRecieving
	@Player NVARCHAR(150)
AS
SELECT [Rank],
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
WHERE Player LIKE '%' + @Player + '%'