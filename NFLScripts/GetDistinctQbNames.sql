USE NFLDB
GO
-- =============================================
-- Author:		Bailey Strum
-- Create date: 2/3/2017
-- Description:	Gets all quarterback names

-- =============================================
CREATE PROCEDURE dbo.sp_GetAllQBNames
	
AS
SELECT DISTINCT Quarterback				
FROM QBStats_2016
GROUP BY Quarterback