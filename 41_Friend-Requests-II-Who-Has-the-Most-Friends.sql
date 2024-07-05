SELECT TOP 1
    ra.id,
    COUNT
    (
        ra.id2
    ) AS num
FROM 
(
    SELECT
        ra1.requester_id AS id,
        ra1.accepter_id AS id2
    FROM RequestAccepted ra1

    UNION ALL

    SELECT
        ra2.accepter_id AS id,
        ra2.requester_id AS id2
    FROM RequestAccepted ra2
) ra
GROUP BY ra.id
ORDER BY 2 DESC