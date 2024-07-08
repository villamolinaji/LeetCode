DECLARE @userName VARCHAR(50)
DECLARE @movie VARCHAR(50)

SELECT TOP 1
    @userName = u.name
FROM MovieRating mr
    JOIN Users u ON u.user_id = mr.user_id
GROUP BY mr.user_id, u.name
HAVING COUNT(mr.user_id) = 
(
    SELECT TOP 1
        COUNT(mr2.user_id)
    FROM MovieRating mr2
    GROUP BY mr2.user_id
    ORDER BY COUNT(mr2.user_id) DESC
)
ORDER BY u.name

SELECT TOP 1
    @movie = m.title
FROM MovieRating mr
    JOIN Movies m ON m.movie_id = mr.movie_id
WHERE YEAR(mr.created_at) = 2020
AND MONTH(mr.created_at) = 2
GROUP BY mr.movie_id, m.title, YEAR(mr.created_at), MONTH(mr.created_at)
HAVING AVG(CAST(mr.rating AS DECIMAL(7, 2))) = 
(
    SELECT TOP 1
        AVG(CAST(mr2.rating AS DECIMAL(7, 2)))
    FROM MovieRating mr2
    WHERE YEAR(mr2.created_at) = 2020
    AND MONTH(mr2.created_at) = 2
    GROUP BY mr2.movie_id, YEAR(mr2.created_at), MONTH(mr2.created_at)
    ORDER BY AVG(CAST(mr2.rating AS DECIMAL(7, 2))) DESC
)
ORDER BY m.title


SELECT @userName AS results

UNION ALL

SELECT @movie AS results