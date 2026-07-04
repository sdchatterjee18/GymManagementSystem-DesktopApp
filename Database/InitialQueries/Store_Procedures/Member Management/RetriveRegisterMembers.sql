CREATE PROC spRetriveRegisterMemberDetails
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        M.MemberId,

        M.FirstName + ' ' +
        ISNULL(M.MiddleName + ' ', '') +
        M.LastName AS MemberName,

        G.GenderName AS Gender,

        M.PhoneNo,
        M.EmailId,

        M.City + ', ' +
        M.District + ', ' +
        M.State AS Address,

        M.EmergencyContact,

        M.ProfilePhoto,

        M.JoiningDate,
        M.UpdatedAt,
        M.IsActive AS MemberIsActive,

        MP.MembershipPlanName,

        MS.StartDate,
        MS.ExpiryDate,

        S.ShiftName,

        DP.ConditionStatus,
        DP.DietPlanDocument,

        L.LockerNo,

        SP.PaymentDate,
        SP.PaymentMethod,
        SP.Amount,
        SP.FeesType

    FROM tblMember M

    LEFT JOIN tblGender G
        ON M.GenderId = G.GenderId

    LEFT JOIN tblMembershipSubscription MS
        ON M.MemberId = MS.MemberId

    LEFT JOIN tblMembershipPlans MP
        ON MS.MembershipPlanId = MP.MembershipPlanId

    LEFT JOIN tblMemberShift MSH
        ON M.MemberId = MSH.MemberId

    LEFT JOIN tblShift S
        ON MSH.ShiftId = S.ShiftId

    LEFT JOIN tblMemberDietAssignment MDA
        ON M.MemberId = MDA.MemberId

    LEFT JOIN tblDietPlans DP
        ON MDA.DietPlanId = DP.DietPlanId

    LEFT JOIN tblLockerAllocation LA
        ON M.MemberId = LA.MemberId

    LEFT JOIN tblLocker L
        ON LA.LockerId = L.LockerId

    LEFT JOIN tblSubscriptionPayment SP
        ON M.MemberId = SP.MemberId

    ORDER BY M.MemberId;
END;
GO