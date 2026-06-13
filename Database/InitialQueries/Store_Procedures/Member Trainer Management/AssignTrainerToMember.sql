CREATE PROC spAssignTrainerToMember
(
    @MemberId INT,
    @TrainerId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentTrainerId INT,
            @AssignedDate DATE;

    SELECT TOP 1
        @CurrentTrainerId = TrainerId,
        @AssignedDate = AssignedDate
    FROM tblMemberTrainerAssignment
    WHERE MemberId = @MemberId
      AND IsActive = 1;

    -- First Time Registration
    IF @CurrentTrainerId IS NULL
    BEGIN
        INSERT INTO tblMemberTrainerAssignment
        (
            MemberId,
            TrainerId,
            AssignedDate,
            IsActive
        )
        VALUES
        (
            @MemberId,
            @TrainerId,
            GETDATE(),
            1
        );

        SELECT
            1 AS Success,
            'Trainer assigned successfully.' AS Message;

        RETURN;
    END

    -- Same Trainer
    IF @CurrentTrainerId = @TrainerId
    BEGIN
        SELECT
            1 AS Success,
            'Member continues with current trainer.' AS Message;

        RETURN;
    END

    -- Same Month Change Not Allowed
    IF YEAR(@AssignedDate) = YEAR(GETDATE())
       AND MONTH(@AssignedDate) = MONTH(GETDATE())
    BEGIN
        SELECT
            0 AS Success,
            'Trainer change is allowed only from next month.' AS Message;

        RETURN;
    END

    -- Next Month Change Allowed
    SELECT
        1 AS Success,
        'Trainer change is allowed.' AS Message;
END
GO