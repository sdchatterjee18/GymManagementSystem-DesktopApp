CREATE PROC spRetrieveMembershipPlanDetailsByName
(
    @MembershipPlanName VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Validation
        ------------------------------------------------
        SET @MembershipPlanName = LTRIM(RTRIM(@MembershipPlanName));

        IF @MembershipPlanName = ''
        BEGIN
            SELECT 'Membership Plan Name is required.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Membership Plan Exists
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMembershipPlans
            WHERE MembershipPlanName = @MembershipPlanName
        )
        BEGIN
            SELECT 'Membership Plan not found.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Retrieve Membership Plan Details
        ------------------------------------------------
        SELECT
            MP.MembershipPlanId,
            MP.MembershipPlanName,
            MPT.PlanType,
            MP.DurationInDays,
            MP.Price,
            MP.Description,
            MP.IsActive
        FROM tblMembershipPlans AS MP
        INNER JOIN tblMembershipPlanType AS MPT
            ON MP.PlanTypeId = MPT.PlanTypeId
        WHERE MP.MembershipPlanName = @MembershipPlanName;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO