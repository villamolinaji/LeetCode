SELECT
    a.sell_date,
    COUNT (DISTINCT a.product) AS num_sold,
    SUBSTRING
    (
        (
            SELECT DISTINCT ',' + a1.product AS [text()]
            FROM Activities a1
            WHERE a1.sell_date = a.sell_date
            FOR XML PATH (''), TYPE
        ).value('text()[1]', 'nvarchar(max)'), 2, 1000
    ) AS products
FROM Activities a
GROUP BY a.sell_date