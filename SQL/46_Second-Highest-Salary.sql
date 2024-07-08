DECLARE @secondHighestSalary INT
SELECT TOP 1
    @secondHighestSalary = e.salary
FROM Employee e
WHERE e.salary <
(
    SELECT MAX(e1.salary)
    FROM Employee e1
)
ORDER BY e.salary DESC

SELECT @secondHighestSalary AS SecondHighestSalary 