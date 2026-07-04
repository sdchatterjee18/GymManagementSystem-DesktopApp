CREATE PROC spChangeMemberDietPlan
(
    @MemberId INT,
    @NewDietPlanId INT
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;

    ----------------------------
    -- Member validation
    ----------------------------
    IF @MemberId IS NULL
    BEGIN
        SELECT 'Member Id is Required.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
    )
    BEGIN
        SELECT 'Invalid Member Id.' AS Message;
        RETURN;
    END

    ----------------------------
    -- Diet Plan validation
    ----------------------------
    IF @NewDietPlanId IS NULL
    BEGIN
        SELECT 'Diet Plan Id is Required.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblDietPlans
        WHERE DietPlanId = @NewDietPlanId
    )
    BEGIN
        SELECT 'Invalid Diet Plan Id.' AS Message;
        RETURN;
    END

    ----------------------------
    -- Check if already assigned same plan
    ----------------------------
    IF EXISTS
    (
        SELECT 1
        FROM tblMemberDietAssignment
        WHERE MemberId = @MemberId
          AND DietPlanId = @NewDietPlanId
          AND IsActive = 1
    )
    BEGIN
        SELECT 'This Diet Plan is Already Active for This Member.' AS Message;
        RETURN;
    END

    ----------------------------
    -- Deactivate current active diet plan
    ----------------------------
    UPDATE tblMemberDietAssignment
    SET IsActive = 0
    WHERE MemberId = @MemberId
      AND IsActive = 1;

    ----------------------------
    -- Assign new diet plan
    ----------------------------
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
        @NewDietPlanId,
        GETDATE(),
        1
    );

    SELECT 'Diet Plan Changed Successfully.' AS Message;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName;

END CATCH
END;
GO