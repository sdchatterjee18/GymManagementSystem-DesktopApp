CREATE PROC spGetMemberCurrentDietPlan
(
    @MemberId INT
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
    -- Get current active diet plan
    ----------------------------
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMemberDietAssignment
        WHERE MemberId = @MemberId
          AND IsActive = 1
    )
    BEGIN
        SELECT 'No Active Diet Plan Found for This Member.' AS Message;
        RETURN;
    END

    ----------------------------
    -- Return full details
    ----------------------------
    SELECT
        MDA.DietAssignmentId,
        M.MemberId,
        M.FirstName,
        M.LastName,
        DP.DietPlanId,
        DP.CaloriesPerDay,
        DP.ConditionStatus,
        MDA.AssignDate,
        MDA.IsActive
    FROM tblMemberDietAssignment MDA
    INNER JOIN tblMember M
        ON MDA.MemberId = M.MemberId
    INNER JOIN tblDietPlans DP
        ON MDA.DietPlanId = DP.DietPlanId
    WHERE MDA.MemberId = @MemberId
      AND MDA.IsActive = 1;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName;

END CATCH
END;
GO