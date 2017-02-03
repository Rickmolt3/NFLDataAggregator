USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 2/3/2017
-- Description:	Gets the teams location,lat,and long

-- =============================================
CREATE PROCEDURE dbo.sp_GetTeamLocation

AS
SELECT TeamCity,
	   Latitude,
	   Longitude


FROM Teams