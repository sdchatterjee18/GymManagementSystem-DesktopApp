CREATE PROCEDURE DisplayPersonalTrainers
AS
BEGIN
	BEGIN TRY
		SELECT  * FROM tblTrainer WHERE TrainerType='Personal Trainer';
	END TRY
	BEGIN CATCH
		SELECT 0 AS ERROR,'Fail to display Personal Trianers' AS MESSAGE;
		SELECT ERROR_MESSAGE() AS MESSAGE;
	END CATCH
END
