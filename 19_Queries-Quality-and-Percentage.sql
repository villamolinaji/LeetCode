SELECT 
    q.query_name,
    ROUND
    (
        SUM(CAST(q.rating AS DECIMAL(7, 2)) / q.position) / COUNT(q.rating)
        , 2
    ) AS quality,
    ROUND
    (
        CAST((100 * SUM
        (
            CASE
                WHEN q.rating < 3 THEN 1
                ELSE 0
            END
        )) AS DECIMAL(7, 2)) / COUNT(q.rating)
        , 2
    ) AS poor_query_percentage
FROM Queries q
WHERE q.query_name IS NOT NULL
GROUP BY q.query_name