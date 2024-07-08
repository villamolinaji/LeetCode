SELECT DISTINCT l.num AS ConsecutiveNums
FROM Logs l
    JOIN Logs l1 ON l1.num = l.num
        AND l1.id = l.id + 1
    JOIN Logs l2 ON l2.num = l.num
        AND l2.id = l.id + 2