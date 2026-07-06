CREATE PROC spRemoveMemberDietPlan
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
    -- Check active diet plan exists
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
    -- Deactivate current diet plan
    ----------------------------
    UPDATE tblMemberDietAssignment
    SET IsActive = 0
    WHERE MemberId = @MemberId
      AND IsActive = 1;

    SELECT 'Member Diet Plan Removed Successfully.' AS Message;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message;

END CATCH
END;
GO