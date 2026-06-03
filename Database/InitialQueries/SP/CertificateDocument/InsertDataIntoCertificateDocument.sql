CREATE PROCEDURE spInsertDataIntoCertificateDocumentTable
(
    @TrainerId INT,
    @Document VARBINARY(MAX)
)
AS
BEGIN
  BEGIN TRY
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblTrainer
        WHERE TrainerId = @TrainerId
    )
    BEGIN
        RAISERROR('Trainer does not exist.',16,1)
        RETURN
    END

    IF @Document IS NULL
    BEGIN
        RAISERROR('Document is required.',16,1)
        RETURN
    END

    INSERT INTO tblCertificateDocument
    (
        TrainerId,
        Document
    )
    VALUES
    (
        @TrainerId,
        @Document
    )

    PRINT 'Certificate Document Uploaded Successfully'
 END TRY
 BEGIN CATCH
    SELECT ERROR_MESSAGE() AS ERRORMESSAGE;
	SELECT ERROR_NUMBER() AS ERRORNUMBER;
	SELECT ERROR_LINE () AS ERRORLINE;
	SELECT ERROR_PROCEDURE() AS ERRORPROCEDURE;
 END CATCH
END
