USE NFLDB
GO
CREATE TABLE Teams(
	TeamID INT PRIMARY KEY IDENTITY(1,1),
	TeamName NVARCHAR(150),
	TeamCity NVARCHAR(150),
	TeamDivision NVARCHAR(150),
	TeamStadium NVARCHAR(150),
	TeamStadiumCapacity INT,
	TeamHeadCoach NVARCHAR(150),
	Latitude DECIMAL(18,4),
	Longitude DECIMAL(18,4) 






)