CREATE PROCEDURE spAddCertificateDocument
(
    @TrainerId INT,
    @Document VARBINARY(MAX) 
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO tblCertificateDocument
        (
            TrainerId,
            Document
        )
        VALUES
        (
            @TrainerId,
            @Document
        );

        SELECT 'Certificate added successfully.' AS Message;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END;
