﻿SELECT
    CONVERT(VARCHAR(7), t.trans_date) AS month,
    t.country,
    COUNT(t.id) AS trans_count,
    SUM
    (
        CASE
            WHEN t.state = 'approved' THEN 1
            ELSE 0
        END
    ) AS approved_count,
    SUM(t.amount) AS trans_total_amount,
    SUM
    (
        CASE
            WHEN t.state = 'approved' THEN t.amount
            ELSE 0
        END
    ) AS approved_total_amount
FROM Transactions t
GROUP BY     
    CONVERT(VARCHAR(7), t.trans_date),
    t.country