SELECT 
    e.employee_id,
    e.name,
    COUNT(em.employee_id) AS reports_count,    
    ROUND(AVG(CAST(em.age AS DECIMAL(9, 4))), 0) AS average_age
FROM Employees e
    JOIN Employees em ON em.reports_to = e.employee_id
GROUP BY 
    e.employee_id,
    e.name
ORDER BY e.employee_id