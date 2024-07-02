SELECT
    p.project_id,
    ROUND
    (
        CAST(SUM(e.experience_years) AS DECIMAL(7, 2)) / COUNT(e.employee_id)
        , 2
    ) AS average_years
FROM Project p
    JOIN Employee e ON e.employee_id = p.employee_id
GROUP BY p.project_id