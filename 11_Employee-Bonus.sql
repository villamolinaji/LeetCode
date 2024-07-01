SELECT
    e.name,
    SUM(b.bonus) AS bonus
FROM Employee e
    LEFT JOIN Bonus b ON b.empId = e.empId
GROUP BY 
    e.empId, 
    e.name
HAVING SUM(IFNULL(b.bonus, 0)) < 1000