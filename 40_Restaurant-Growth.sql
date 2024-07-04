SELECT
    c.visited_on,
    (
        SELECT SUM(cc.amount)
        FROM Customer cc
        WHERE cc.visited_on <= c.visited_on
        AND cc.visited_on >= DATEADD(day, -6, c.visited_on)
    ) AS amount,
    ROUND
    (        
        (
            SELECT SUM(cc.amount)
            FROM Customer cc
            WHERE cc.visited_on <= c.visited_on
            AND cc.visited_on >= DATEADD(day, -6, c.visited_on)
        ) / 7.0
        , 2
    ) AS average_amount
FROM Customer c
WHERE EXISTS
(
    SELECT 1
    FROM Customer c1
    WHERE c1.visited_on = DATEADD(day, -1, c.visited_on)
)
AND EXISTS
(
    SELECT 1
    FROM Customer c2
    WHERE c2.visited_on = DATEADD(day, -2, c.visited_on)
)
AND EXISTS
(
    SELECT 1
    FROM Customer c3
    WHERE c3.visited_on = DATEADD(day, -3, c.visited_on)
)
AND EXISTS
(
    SELECT 1
    FROM Customer c4
    WHERE c4.visited_on = DATEADD(day, -4, c.visited_on)
)
AND EXISTS
(
    SELECT 1
    FROM Customer c5
    WHERE c5.visited_on = DATEADD(day, -5, c.visited_on)
)
AND EXISTS
(
    SELECT 1
    FROM Customer c6
    WHERE c6.visited_on = DATEADD(day, -6, c.visited_on)
)
GROUP BY c.visited_on
