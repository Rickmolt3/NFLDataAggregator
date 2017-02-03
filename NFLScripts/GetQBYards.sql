

DECLARE

	@Quarterback NVARCHAR(150) = 'Matt Ryan',
	@Quarterback2 NVARCHAR(150) = 'Aaron Rodgers',
	@Yards INT,
	@Yards2 INT


SELECT @Yards = SUM(QBS.Yards)
FROM QBStats_2016 AS QBS
WHERE Quarterback LIKE '%' + @Quarterback + '%'
Group By Quarterback

SELECT @Yards2 = SUM(QBS.Yards)
FROM QBStats_2016 AS QBS
WHERE Quarterback LIKE '%' + @Quarterback2 + '%'
Group By Quarterback


SELECT @Quarterback [Quarterback],
	@Yards [Yards],
	@Quarterback2 [Quarterback2],
	@Yards2 [Yards2]
