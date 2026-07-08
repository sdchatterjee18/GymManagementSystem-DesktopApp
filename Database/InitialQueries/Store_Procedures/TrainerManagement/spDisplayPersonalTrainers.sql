Create PROCEDURE DisplayPersonalTrainers
AS
BEGIN
	BEGIN TRY
		SELECT  * FROM tblTrainer WHERE TrainerType='Personal Trainer';
	END TRY
	BEGIN CATCH	
		SELECT ERROR_MESSAGE() AS Message;
	END CATCH
END
