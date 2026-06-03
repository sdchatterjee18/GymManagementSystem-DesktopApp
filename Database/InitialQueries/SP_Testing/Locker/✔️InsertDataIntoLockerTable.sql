CREATE PROC spInsertDataIntoLockerTable
(
    @LockerNo VARCHAR(20),
    @LockerStatus VARCHAR(50)
)
AS
BEGIN
BEGIN TRY
    SET @LockerNo = LTRIM(RTRIM(@LockerNo));
    SET @LockerStatus = LTRIM(RTRIM(@LockerStatus));
    IF @LockerNo IS NULL OR @LockerNo = ''
    BEGIN
        SELECT 'Locker Number is Required.' AS Message;
        RETURN;
    END
    IF @LockerStatus IS NULL OR @LockerStatus = ''
    BEGIN
        SELECT 'Locker Status is Required.' AS Message;
        RETURN;
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblLocker
        WHERE LockerNo = @LockerNo
    )
    BEGIN
        SELECT 'Locker Number Already Exists.' AS Message;
        RETURN;
    END
    INSERT INTO tblLocker
    (
        LockerNo,
        LockerStatus
    )
    VALUES
    (
        @LockerNo,
        @LockerStatus
    );
    SELECT 'Locker Inserted Successfully.' AS Message;
END TRY
BEGIN CATCH
    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName;
END CATCH
END
GO
