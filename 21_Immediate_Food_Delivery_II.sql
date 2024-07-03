SELECT 
    ROUND
    (
        SUM
        (
            CASE
                WHEN dd.FirstOrderDate = d.customer_pref_delivery_date THEN 1.0
                ELSE 0.0
            END
        ) * 100 / COUNT(DISTINCT d.customer_id)
        , 2
    ) AS immediate_percentage
FROM Delivery d
    OUTER APPLY 
    (
        SELECT
            d1.customer_id,
            MIN(d1.order_date) AS FirstOrderDate
        FROM Delivery d1
        GROUP BY d1.customer_id
    ) dd 
WHERE d.customer_id = dd.customer_id