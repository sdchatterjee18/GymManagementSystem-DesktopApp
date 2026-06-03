CREATE PROCEDURE spInsertDataIntoMemberDietAssignmentTable
    @MemberId  INT ,
    @DietPlanId INT
AS
BEGIN
BEGIN TRY
    SET NOCOUNT ON;

    SET @MemberId   = LTRIM(RTRIM(ISNULL(@MemberId, '')))
    SET @DietPlanId = LTRIM(RTRIM(ISNULL(@DietPlanId, '')))

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

    IF @DietPlanId = ''
    BEGIN
        SELECT 'DietPlanId is required and cannot be NULL.' AS Message;
        RETURN;
    END

    IF @DietPlanId <= 0
    BEGIN
        SELECT 'DietPlanId must be a positive integer.' AS Message;
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM tblDietPlans WHERE DietPlanId = @DietPlanId)
    BEGIN
        SELECT 'DietPlanId does not exist in the DietPlans table.' AS Message;
        RETURN;
    END

    IF EXISTS (
        SELECT 1 FROM tblMemberDietAssignment
        WHERE MemberId   = @MemberId
        AND   DietPlanId = @DietPlanId
        AND   IsActive   = 1
    )
    BEGIN
        SELECT 'This Member is already actively assigned to the given Diet Plan.' AS Message;
        RETURN;
    END

    INSERT INTO tblMemberDietAssignment
    (
        MemberId,
        DietPlanId,
        AssignDate,
        IsActive
    )
    VALUES
    (
        @MemberId,
        @DietPlanId,
        GETDATE(),
        1
    );

    SELECT 'Member Diet Assignment record inserted successfully.' AS Message

END TRY
BEGIN CATCH
    SELECT
        ERROR_MESSAGE()   AS Message,
        ERROR_LINE()      AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName
END CATCH
END
GO