DECLARE @minDate date
SELECT @minDate = DATEADD(day, -30, '2019-07-27')

SELECT 
    a.activity_date AS day,
    COUNT(DISTINCT a.user_id) AS active_users
FROM Activity a
WHERE a.activity_date <= '2019-07-27'
AND a.activity_date > @minDate
GROUP BY a.activity_date