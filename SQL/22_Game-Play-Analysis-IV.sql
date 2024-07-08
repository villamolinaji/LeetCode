SELECT
    ROUND
    (
        SUM
        (
            CASE
                WHEN a.event_date = DATEADD(day, 1, aa.FirstEventDate) THEN 1.0
                ELSE 0.0
            END
        ) / COUNT(DISTINCT a.player_id)
        , 2
    ) AS fraction
FROM Activity a
    OUTER APPLY
    (
        SELECT
            a1.player_id,
            MIN(a1.event_date) AS FirstEventDate
        FROM Activity a1
        GROUP BY a1.player_id
    ) aa
WHERE a.player_id = aa.player_id