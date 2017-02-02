USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 2/2/2017
-- Description:	Gets the rusher by name

-- =============================================
CREATE PROCEDURE dbo.sp_GetRushingStats
	@Name NVARCHAR(150)
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
WHERE [Name] LIKE '%' + @Name + '%'