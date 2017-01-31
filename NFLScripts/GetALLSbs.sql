USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Gets all the superbowls and returns the data with each

-- =============================================
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
