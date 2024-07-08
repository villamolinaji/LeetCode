SELECT
    s.product_id,
    ss.first_year,
    s.quantity,
    s.price
FROM Sales s
    OUTER APPLY
    (
        SELECT
            s2.product_id,
            MIN(s2.year) AS first_year
        FROM Sales s2
        GROUP BY s2.product_id
    ) ss
WHERE s.product_id = ss.product_id
AND s.year = ss.first_year