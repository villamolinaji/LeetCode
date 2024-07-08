SELECT 
    a.machine_id,
    ROUND(AVG(a3.timestamp - a.timestamp), 3) AS processing_time 
FROM Activity a    
    JOIN Activity a3 ON a3.machine_id = a.machine_id
        AND a3.process_id = a.process_id
        AND a3.activity_type = 'end'    
WHERE a.activity_type = 'start'
GROUP BY a.machine_id