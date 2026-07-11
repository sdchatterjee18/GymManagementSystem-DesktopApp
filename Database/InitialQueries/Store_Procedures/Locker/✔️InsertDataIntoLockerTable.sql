CREATE PROC spInsertDataIntoLockerTable
(
    @LockerNo VARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @LockerNo = LTRIM(RTRIM(@LockerNo));

        -----------------------------------------
        -- Locker Number Validation
        -----------------------------------------
        IF @LockerNo IS NULL OR @LockerNo = ''
        BEGIN
            SELECT 'Locker Number is Required.' AS Message;
            RETURN;
        END;

        -----------------------------------------
        -- Duplicate Locker Check
        -----------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblLocker
            WHERE LockerNo = @LockerNo
        )
        BEGIN
            SELECT 'Locker Number Already Exists.' AS Message;
            RETURN;
        END;

        -----------------------------------------
        -- Insert Locker
        -----------------------------------------
        INSERT INTO tblLocker
        (
            LockerNo,
            LockerStatus
        )
        VALUES
        (
            @LockerNo,
            'Available'
        );

        SELECT 'Locker Inserted Successfully.' AS Message;

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO