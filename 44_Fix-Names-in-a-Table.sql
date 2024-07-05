SELECT
    u.user_id,
    UPPER(SUBSTRING(u.name, 1, 1)) + LOWER(SUBSTRING(u.name, 2, LEN(u.name) - 1)) AS name
FROM Users u
ORDER BY u.user_id