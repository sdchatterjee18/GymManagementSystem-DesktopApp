CREATE PROC spInsertDataIntoRegistrationFeesTable
(
    @FeeAmount DECIMAL(10,2)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF @FeeAmount IS NULL
        BEGIN
            SELECT 'Fee Amount is Required.' AS Message;
            RETURN;
        END;

        IF @FeeAmount < 0
        BEGIN
            SELECT 'Fee Amount Cannot Be Negative.' AS Message;
            RETURN;
        END;

        IF EXISTS
        (
            SELECT 1
            FROM tblRegistrationFees
            WHERE FeeAmount = @FeeAmount
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Registration Fee Already Exists.' AS Message;
            RETURN;
        END;

        INSERT INTO tblRegistrationFees
        (
            FeeAmount
        )
        VALUES
        (
            @FeeAmount
        );

        SELECT 'Registration Fee Inserted Successfully.' AS Message;

    END TRY
    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO