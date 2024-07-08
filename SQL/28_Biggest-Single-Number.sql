DECLARE @num INT
SELECT TOP 1 @num = n.num
FROM MyNumbers n
GROUP BY n.num
HAVING COUNT(n.num) = 1
ORDER BY n.num DESC

SELECT @num AS num