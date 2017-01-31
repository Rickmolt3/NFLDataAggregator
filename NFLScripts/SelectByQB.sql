USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Gets a quarterback based on their name and returns all the db info

-- =============================================
CREATE PROCEDURE dbo.sp_getQB
	@Quarterback NVARCHAR(100)
AS
SELECT 
			Quarterback,
			Attempt,
			Completion,
			Yards,
			YardsPerAttempt,
			Touchdown,
			Interception,
			Long,
			Sack,
			Loss,
			Rate,
			TotalPoints,
			HomeOrAway,
			[Year]

		FROM QBStats_2016

		WHERE Quarterback LIKE '%'+ @Quarterback +'%'