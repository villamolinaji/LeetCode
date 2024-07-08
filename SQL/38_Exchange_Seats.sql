SELECT
    s.id,
    ISNULL(ss.student, s.student) AS student
FROM Seat s
    LEFT JOIN Seat ss ON ss.id = 
        CASE
            WHEN s.id % 2 = 1 THEN s.id + 1
            ELSE s.id - 1
        END