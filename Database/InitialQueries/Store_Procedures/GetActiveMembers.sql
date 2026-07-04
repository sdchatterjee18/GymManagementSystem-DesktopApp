CREATE PROC spGetActiveMembers
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            M.MemberId,
            M.FirstName,
            M.MiddleName,
            M.LastName,
            M.PhoneNo,
            M.EmailId,
            M.City,
            M.District,
            M.State,
            M.EmergencyContact,
            M.ProfilePhoto,
            M.JoiningDate,
            M.UpdatedAt,
            MP.MembershipPlanName,
            MS.StartDate,
            MS.ExpiryDate,
            MS.IsActive AS MembershipStatus
        FROM tblMember M
        INNER JOIN tblMembershipSubscription MS
            ON M.MemberId = MS.MemberId
        INNER JOIN tblMembershipPlans MP
            ON MS.MembershipPlanId = MP.MembershipPlanId
        WHERE MS.MemberSubscriptionId =
        (
            SELECT MAX(MemberSubscriptionId)
            FROM tblMembershipSubscription
            WHERE MemberId = M.MemberId
        )
        AND MS.IsActive = 1;

    END TRY

    BEGIN CATCH

        SELECT
            0 AS Success,
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO