CREATE PROC spInsertDataIntoGenderTable
(
    @GenderName VARCHAR(20)
)
AS
BEGIN
BEGIN TRY
    SET @GenderName = LTRIM(RTRIM(@GenderName))
    IF @GenderName IS NULL OR @GenderName = ''
    BEGIN
        SELECT 'Gender Name is Required.' AS Message
        RETURN
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblGender
        WHERE GenderName = @GenderName
    )
    BEGIN
        SELECT 'Gender Already Exists.' AS Message
        RETURN
    END
    INSERT INTO tblGender
    (
        GenderName
    )
    VALUES
    (
        @GenderName
    )
    SELECT 'Gender Inserted Successfully.' AS Message
END TRY
BEGIN CATCH
    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName
END CATCH
END
GO