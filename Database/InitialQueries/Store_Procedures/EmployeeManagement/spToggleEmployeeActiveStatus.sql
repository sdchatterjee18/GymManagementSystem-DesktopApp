CREATE PROC spToggleEmployeeActiveStatus
(
    @EmployeeId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        BEGIN TRANSACTION;

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE EmployeeId = @EmployeeId
        )
        BEGIN
            SELECT 'Employee not found.' AS Message;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        DECLARE @CurrentStatus BIT;
        DECLARE @TrainerId INT;
        DECLARE @TrainerType VARCHAR(100);

        SELECT @CurrentStatus = IsActive
        FROM tblEmployee
        WHERE EmployeeId = @EmployeeId;

        UPDATE tblEmployee
        SET IsActive =
            CASE
                WHEN IsActive = 1 THEN 0
                ELSE 1
            END
        WHERE EmployeeId = @EmployeeId;

        SELECT
            @TrainerId = TrainerId,
            @TrainerType = TrainerType
        FROM tblTrainer
        WHERE EmployeeId = @EmployeeId;

        IF @TrainerId IS NOT NULL
           AND @TrainerType = 'Personal'
        BEGIN

            IF @CurrentStatus = 1
            BEGIN
                DELETE FROM tblTrainerShift
                WHERE TrainerId = @TrainerId;

                UPDATE tblMemberTrainerAssignment
                SET IsActive = 0
                WHERE TrainerId = @TrainerId;
            END

            ELSE
            BEGIN

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

        END

        COMMIT TRANSACTION;

        SELECT 'Employee status updated successfully.' AS Message;

    END TRY
    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO