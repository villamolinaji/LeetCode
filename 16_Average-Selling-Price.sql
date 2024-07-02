SELECT
    p.product_id,
    ROUND
    (
        ISNULL((CAST(SUM(p.price * ud.units) AS DECIMAL(7, 2)) / SUM(ud.units)), 0)
        , 2
    ) AS average_price
FROM Prices p
    LEFT JOIN UnitsSold ud ON ud.product_id = p.product_id
        AND p.start_date <= ud.purchase_date
        AND p.end_date >= ud.purchase_date
GROUP BY p.product_id