USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Gets the team by their name and returns all db values

-- =============================================
CREATE PROCEDURE dbo.sp_GetTeam
	@TeamName NVARCHAR(150)
AS
SELECT TeamName,
	   TeamCity,
	   TeamDivision,
	   TeamStadium,
	   TeamStadiumCapacity,
	   TeamHeadCoach,
	   Latitude,
	   Longitude

FROM Teams
WHERE TeamName LIKE '%' + @TeamName + '%'
