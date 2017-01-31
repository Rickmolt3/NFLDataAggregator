-- =============================================
-- Author:		Bailey Strum
-- Create date: 1/31/2017
-- Description:	Used this to delete excess data from my datasets once they were inserted into sql

-- =============================================
WITH cte
     AS (SELECT *,
                row_number() OVER (ORDER BY [Rank]) AS rn
         FROM runningbackdata)
DELETE FROM cte
WHERE  rn > 50 