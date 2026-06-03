CREATE PROC spInsertDataIntoTrainerShiftTable
(
	@TrainerId INT,
	@ShiftId INT,
	@IsActive BIT
)
AS BEGIN
	BEGIN TRY
		IF NOT EXISTS
		(
			SELECT 1
			FROM tblTrainer
			WHERE TrainerId=@TrainerId
		)
		BEGIN
			RAISERROR('TrainerId does not exists',16,1)
			RETURN
		END
		IF NOT EXISTS
		(
			SELECT 1
			FROM tblShift
			WHERE ShiftId = @ShiftId
		)
		BEGIN
			RAISERROR('Shift does not exists',16,1)
		END

		IF @IsActive IS NULL
			RAISERROR('IsActive is required',16,1)

		IF EXISTS
		(
			SELECT 1
			FROM tblTrainerShift
			WHERE TrainerId=@TrainerId
			AND ShiftId = @ShiftId
		)
		BEGIN
			RAISERROR('Trainer is already assigned in this Shift',16,1)
		END
		INSERT INTO tblTrainerShift
		(
			TrainerId,
			ShiftId,
			IsActive
		)
		VALUES
		(
			@TrainerId,
			@ShiftId,
			@IsActive
		)
		PRINT 'Trainer-Shift assigned successfully'
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS ErrorMessage
		SELECT ERROR_LINE() AS ErrorMessage
		SELECT ERROR_PROCEDURE() AS ErrorMessage
	END CATCH
END
