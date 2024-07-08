﻿SELECT
    e.employee_id
FROM Employees e
WHERE e.salary < 30000
AND NOT EXISTS
(
    SELECT 1
    FROM Employees em
    WHERE em.employee_id = e.manager_id
)
AND e.manager_id IS NOT NULL
ORDER BY e.employee_id