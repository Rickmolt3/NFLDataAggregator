USE NFLDB
GO
ALTER  PROCEDURE dbo.sp_getQB
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