DECLARE @numProducts INT
SELECT @numProducts = COUNT(p.product_key)
FROM Product p

SELECT 
    c.customer_id
FROM Customer c
GROUP BY c.customer_id
HAVING COUNT(DISTINCT c.product_key) = @numProducts