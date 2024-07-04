DECLARE @lowSalary INT
DECLARE @averageSalary INT
DECLARE @highSalary INT

SELECT @lowSalary = COUNT(a.account_id)
FROM Accounts a
WHERE a.income < 20000

SELECT @averageSalary = COUNT(a.account_id)
FROM Accounts a
WHERE a.income >= 20000
AND a.income <= 50000

SELECT @highSalary = COUNT(a.account_id)
FROM Accounts a
WHERE a.income > 50000

SELECT 
    'Low Salary' AS category, 
    @lowSalary AS accounts_count

UNION

SELECT 
    'Average Salary' AS category, 
    @averageSalary AS accounts_count

UNION

SELECT 
    'High Salary' AS category, 
    @highSalary AS accounts_count