SELECT DISTINCT
    d.name AS Department,
    e.name AS Employee,
    e.Salary AS Salary
FROM Department d
    JOIN Employee e ON e.departmentId = d.id
        AND e.Salary IN
        (
            SELECT DISTINCT TOP 3                
                e2.salary
            FROM Employee e2
            WHERE e2.departmentId = e.departmentId
            ORDER BY e2.salary DESC
        )