CREATE PROC spInsertDataIntoEmployeeRoleTypeTable
(
    @Role VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @Role = LTRIM(RTRIM(@Role));

        IF @Role IS NULL
           OR @Role = ''
        BEGIN
            SELECT
                0 AS StatusCode,
                'Role is required.' AS Message;
            RETURN;
        END;

        IF EXISTS
        (
            SELECT 1
            FROM tblEmployeeRoleType
            WHERE Role = @Role
        )
        BEGIN
            SELECT
                0 AS StatusCode,
                'Role already exists.' AS Message;
            RETURN;
        END;

        INSERT INTO tblEmployeeRoleType
        (
            Role
        )
        VALUES
        (
            @Role
        );

        SELECT
            1 AS StatusCode,
            'Employee Role inserted successfully.' AS Message;

    END TRY
    BEGIN CATCH

        SELECT
            0 AS StatusCode,
            ERROR_MESSAGE() AS Message,
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ErrorProcedure;

    END CATCH
END;