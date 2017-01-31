USE NFLDB
GO
ALTER PROCEDURE dbo.sp_GetTeam
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
