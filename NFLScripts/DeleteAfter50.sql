WITH cte
     AS (SELECT *,
                row_number() OVER (ORDER BY [Rank]) AS rn
         FROM runningbackdata)
DELETE FROM cte
WHERE  rn > 50 