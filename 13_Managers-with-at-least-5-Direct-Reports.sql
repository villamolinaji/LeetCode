SELECT e.name
FROM Employee e
WHERE
(
    SELECT COUNT(e2.id)
    FROM Employee e2
    WHERE e2.managerId = e.id
) >= 5


SELECT e.name
FROM Employee e
    OUTER APPLY
    (
        SELECT 
            COUNT(e2.id) AS DirectReports,
            e2.managerId
        FROM Employee e2
        GROUP BY e2.managerId
    ) m 
WHERE m.managerId = e.id
AND m.DirectReports >= 5