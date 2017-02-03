USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 2/2/2017
-- Description:	Gets the quarterbacks selected and their yardage

-- =============================================
ALTER PROCEDURE dbo.sp_GetChartStats
	@Quarterback NVARCHAR(150),
	@Quarterback2 NVARCHAR(150)
AS
	DECLARE @Yards AS INT 
	DECLARE @Yards2  AS INT 
	DECLARE @touchdown AS INT
	DECLARE @touchdown2 AS INT


SELECT @Yards = SUM(QBS.Yards)
FROM QBStats_2016 AS QBS
WHERE Quarterback LIKE '%' + @Quarterback + '%'
Group By Quarterback

SELECT @Yards2 = SUM(QBS.Yards)
FROM QBStats_2016 AS QBS
WHERE Quarterback LIKE '%' + @Quarterback2 + '%'
Group By Quarterback

SELECT @touchdown = SUM(QBS.Touchdown)
FROM QBStats_2016 AS QBS
WHERE Quarterback LIKE '%' + @Quarterback + '%'
Group By Quarterback

SELECT @touchdown2 = SUM(QBS.Touchdown)
FROM QBStats_2016 AS QBS
WHERE Quarterback LIKE '%' + @Quarterback2 + '%'
Group By Quarterback


SELECT @Quarterback [Quarterback],
	@Yards [Yards],
	@Quarterback2 [Quarterback2],
	@Yards2 [Yards2],
	@touchdown [touchdown],
	@touchdown2 [touchdown2]
