CREATE PROCEDURE spUpdateTrainerTypeByTrainerId
(
    @TrainerId INT,
    @TrainerType VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        BEGIN TRANSACTION;

        SET @TrainerType = LTRIM(RTRIM(@TrainerType));

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer
            WHERE TrainerId = @TrainerId
        )
        BEGIN
            SELECT 'Trainer not found.' AS Message;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        IF @TrainerType NOT IN ('Personal','General')
        BEGIN
            SELECT 'Invalid trainer type.' AS Message;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        DECLARE @CurrentTrainerType VARCHAR(100);

        SELECT @CurrentTrainerType = TrainerType
        FROM tblTrainer
        WHERE TrainerId = @TrainerId;

        IF @CurrentTrainerType = @TrainerType
        BEGIN
            SELECT 'Trainer type is already assigned.' AS Message;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        IF @CurrentTrainerType = 'Personal'
           AND @TrainerType = 'General'
        BEGIN

            UPDATE tblTrainer
            SET TrainerType = 'General'
            WHERE TrainerId = @TrainerId;

            UPDATE tblTrainerShift
            SET IsActive = 0
            WHERE TrainerId = @TrainerId;

            UPDATE tblMemberTrainerAssignment
            SET IsActive = 0
            WHERE TrainerId = @TrainerId;

        END

        ELSE IF @CurrentTrainerType = 'General'
            AND @TrainerType = 'Personal'
        BEGIN

            UPDATE tblTrainer
            SET TrainerType = 'Personal'
            WHERE TrainerId = @TrainerId;

            INSERT INTO tblTrainerShift
            (
                TrainerId,
                ShiftId
            )
            SELECT
                @TrainerId,
                ShiftId
            FROM tblShift;

        END

        COMMIT TRANSACTION;

        SELECT 'Trainer type updated successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO
