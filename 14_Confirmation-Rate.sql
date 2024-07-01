SELECT
    s.user_id,      
    CASE
        WHEN COUNT(c.time_stamp) > 0 THEN
            ROUND
            (
                SUM
                (
                    CASE 
                        WHEN c.action = 'confirmed' THEN 1.0
                        ELSE 0.0
                    END
                ) / COUNT(c.time_stamp)
                , 2
            )
        ELSE 0
    END AS confirmation_rate
FROM Signups s
    LEFT JOIN Confirmations c ON c.user_id = s.user_id
GROUP BY s.user_id, c.user_id