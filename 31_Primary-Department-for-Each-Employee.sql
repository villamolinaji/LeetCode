SELECT
	e.employee_id,
	e.department_id
FROM Employee e	
WHERE e.department_id =
(
	SELECT		
		ee.department_id
	FROM Employee ee
	WHERE ee.employee_id = e.employee_id
	AND ee.primary_flag = 'Y'
)
OR 
(
	SELECT COUNT(ee.department_id)
	FROM Employee ee
	WHERE ee.employee_id = e.employee_id	
) = 1