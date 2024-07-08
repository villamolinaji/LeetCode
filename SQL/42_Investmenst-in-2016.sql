SELECT 
    ROUND(SUM(i.tiv_2016), 2) AS tiv_2016
FROM Insurance i
WHERE EXISTS
(
    SELECT 1
    FROM Insurance i2
    WHERE i2.pid <> i.pid
    AND i2.tiv_2015 = i.tiv_2015    
)
AND NOT EXISTS
(
    SELECT 1
    FROM Insurance i2
    WHERE i2.pid <> i.pid
    AND i2.lat = i.lat
    AND i2.lon = i.lon
)