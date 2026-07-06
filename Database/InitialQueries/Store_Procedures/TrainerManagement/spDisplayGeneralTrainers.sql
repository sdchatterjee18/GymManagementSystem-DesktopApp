CREATE PROCEDURE DisplayGeneralTrainers
AS
BEGIN
	BEGIN TRY
		SELECT  * FROM tblTrainer WHERE TrainerType='Genaral Trainer';
	END TRY
	BEGIN CATCH
		SELECT 'Fail to display Personal Trianers' AS MESSAGE;
		SELECT ERROR_MESSAGE() AS MESSAGE;
	END CATCH
END