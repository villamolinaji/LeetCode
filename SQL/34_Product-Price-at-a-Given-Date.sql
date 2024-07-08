SELECT DISTINCT
    p.product_id,
    CASE
        WHEN pp.product_id IS NULL THEN 10
        ELSE p.new_price
    END AS price    
FROM Products p
    LEFT JOIN
    (
        SELECT
            p1.product_id,
            MAX(change_date) AS change_date            
        FROM Products p1
        WHERE p1.change_date <= '2019-08-16'
        GROUP BY p1.product_id        
    ) pp ON p.product_id = pp.product_id 
        AND p.change_date = pp.change_date
WHERE pp.product_id IS NOT NULL 
OR NOT EXISTS
(
    SELECT 1        
    FROM Products p1
    WHERE p1.product_id = p.product_id
    AND p1.change_date <= '2019-08-16'            
)