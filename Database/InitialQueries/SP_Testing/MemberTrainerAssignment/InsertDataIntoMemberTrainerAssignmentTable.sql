CREATE PROCEDURE spInsertDataIntoMemberTrainerAssignmentTable
    @MemberId  INT ,
    @TrainerId INT
AS
BEGIN
BEGIN TRY
    SET NOCOUNT ON;

    SET @MemberId = LTRIM(RTRIM(ISNULL(@MemberId, '')));
    SET @TrainerId= LTRIM(RTRIM(ISNULL(@TrainerId, '')));

    IF @MemberId = ''
    BEGIN
        SELECT 'MemberId is required and cannot be NULL.' AS Message;
        RETURN;
    END

    IF @MemberId <= 0
    BEGIN
        SELECT 'MemberId must be a positive integer.' AS Message;
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM tblMember WHERE MemberId = @MemberId)
    BEGIN
        SELECT 'MemberId does not exist in the Member table.' AS Message;
        RETURN;
    END

    IF @TrainerId = ''
    BEGIN
        SELECT 'TrainerId is required and cannot be NULL.' AS Message;
        RETURN;
    END

    IF @TrainerId <= 0
    BEGIN
        SELECT 'TrainerId must be a positive integer.' AS Message;
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM tblTrainer WHERE TrainerId = @TrainerId)
    BEGIN
        SELECT 'TrainerId does not exist in the Trainer table.' AS Message;
        RETURN;
    END

    IF EXISTS (
        SELECT 1 FROM tblMemberTrainerAssignment 
        WHERE MemberId = @MemberId 
        AND   TrainerId = @TrainerId 
        AND   IsActive = 1
    )
    BEGIN
        SELECT 'This Member is already actively assigned to the given Trainer.' AS Message;
        RETURN;
    END

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
        1 -- 1 'true' and 0 'false'
    );

    SELECT 'Member Trainer Assignment record inserted successfully.' AS Message

END TRY
BEGIN CATCH
    SELECT
        ERROR_MESSAGE()   AS Message,
        ERROR_LINE()      AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName
END CATCH
END
GO