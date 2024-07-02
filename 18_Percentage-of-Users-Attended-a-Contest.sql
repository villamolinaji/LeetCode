DECLARE @users AS INT
SELECT @users = COUNT(u.user_id)
FROM Users u

SELECT
    r.contest_id,
    ROUND
    (
        CAST((COUNT(u.user_id) * 100) AS DECIMAL(7, 2)) / @users
        , 2
    ) AS percentage 
FROM Register r
    LEFT JOIN Users u ON u.user_id = r.user_id
GROUP BY r.contest_id
ORDER BY 2 DESC, r.contest_id