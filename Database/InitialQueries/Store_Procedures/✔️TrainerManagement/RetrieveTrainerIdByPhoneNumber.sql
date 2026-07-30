CREATE PROC spRetrieveTrainerIdByPhoneNumber
(
    @PhoneNo VARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @PhoneNo = LTRIM(RTRIM(@PhoneNo));

        IF @PhoneNo = ''
        BEGIN
            SELECT 'Phone Number is required.' AS Message;
            RETURN;
        END;

        IF LEN(@PhoneNo) <> 10
        BEGIN
            SELECT 'Phone Number must be 10 digits.' AS Message;
            RETURN;
        END;

        IF @PhoneNo LIKE '%[^0-9]%'
        BEGIN
            SELECT 'Phone Number must contain only digits.' AS Message;
            RETURN;
        END;

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer T
            INNER JOIN tblEmployee E
                ON T.EmployeeId = E.EmployeeId
            WHERE E.PhoneNo = @PhoneNo
        )
        BEGIN
            SELECT 'Trainer not found.' AS Message;
            RETURN;
        END;

        SELECT
            T.TrainerId
        FROM tblTrainer T
        INNER JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        WHERE E.PhoneNo = @PhoneNo;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO