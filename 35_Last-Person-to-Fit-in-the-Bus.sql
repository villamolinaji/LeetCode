DECLARE @personName NVARCHAR(50)
DECLARE @prevName NVARCHAR(50)
DECLARE @weight INT
DECLARE @sumWeight INT = 0
DECLARE @isFinish BIT = 0

DECLARE qCursor CURSOR FOR
SELECT 
    q.person_name,
    q.weight
FROM Queue q
ORDER BY q.turn
OPEN qCursor

FETCH NEXT FROM qCursor
INTO @personName, @weight

WHILE @@FETCH_STATUS = 0 AND @isFinish  = 0
BEGIN

    SET @sumWeight = @sumWeight + @weight

    IF @sumWeight > 1000
    BEGIN
        SELECT @prevName AS person_name
        SET @isFinish = 1
    END

    SET @prevName = @personName

    FETCH NEXT FROM qCursor
    INTO @personName, @weight
END

IF @isFinish = 0
BEGIN
    SELECT @personName AS person_name
END

CLOSE qCursor;
DEALLOCATE qCursor;