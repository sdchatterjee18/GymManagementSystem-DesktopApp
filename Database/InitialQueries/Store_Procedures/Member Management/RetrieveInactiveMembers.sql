CREATE PROC spRetrieveInactiveMembers
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
        AND M.IsActive = 0;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO