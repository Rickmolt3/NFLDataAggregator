USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Gets the players by their team and return it to the datacontroller

-- =============================================
CREATE PROCEDURE dbo.sp_GetTeam
	@TeamName NVARCHAR(150)
AS
SELECT tms.TeamName,
	   tms.TeamCity,
	   tms.TeamDivision,
	   tms.TeamStadium,
	   tms.TeamStadiumCapacity,
	   tms.TeamHeadCoach,
	   tms.Latitude,
	   tms.Longitude,
	   rd.Player,
	   rd.Position [recievingPosition],
	   rbd.[Name],
	   rbd.Position [runningPosition]


FROM Teams AS tms
LEFT JOIN recievingdata AS rd
ON tms.TeamName = rd.Team
LEFT JOIN runningbackdata AS rbd
ON tms.TeamName = rbd.Team
WHERE TeamName LIKE '%' + @TeamName + '%'
