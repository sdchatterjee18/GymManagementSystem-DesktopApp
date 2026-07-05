CREATE PROC spInsertDataIntoRegistrationFeesTable
(
    @FeeAmount DECIMAL(10,2)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Validation
        ------------------------------------------------
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

        ------------------------------------------------
        -- Same Active Fee Already Exists
        ------------------------------------------------
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

        BEGIN TRANSACTION;

        ------------------------------------------------
        -- If Active Fee Exists Then Deactivate It
        ------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblRegistrationFees
            WHERE IsActive = 1
        )
        BEGIN
            UPDATE tblRegistrationFees
            SET IsActive = 0
            WHERE IsActive = 1;
        END;

        ------------------------------------------------
        -- Insert New Active Registration Fee
        ------------------------------------------------
        INSERT INTO tblRegistrationFees
        (
            FeeAmount,
            IsActive
        )
        VALUES
        (
            @FeeAmount,
            1
        );

        COMMIT TRANSACTION;

        SELECT
            'Registration Fee Updated Successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO