CREATE PROC spRetriveRegisterMemberDetails
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        tblMember.MemberId,
        tblMember.FirstName + ' ' +
        ISNULL(tblMember.MiddleName + ' ', '') +
        tblMember.LastName AS MemberName,
        tblGender.GenderName AS Gender,
        tblMember.PhoneNo,
        tblMember.EmailId,
        tblMember.City + ', ' +
        tblMember.District + ', ' +
        tblMember.State AS Address,
        tblMember.ProfilePhoto,
        tblMember.IsActive AS MemberIsActive,
        tblMembershipPlans.MembershipPlanName,
        tblMembershipSubscription.StartDate,
        tblMembershipSubscription.ExpiryDate,
        tblShift.ShiftName,
        tblDietPlans.ConditionStatus,
        tblDietPlans.DietPlanDocument,
        tblLocker.LockerNo
    FROM tblMember
    LEFT JOIN tblGender
        ON tblMember.GenderId = tblGender.GenderId
    LEFT JOIN tblMembershipSubscription
        ON tblMember.MemberId = tblMembershipSubscription.MemberId
    LEFT JOIN tblMembershipPlans
        ON tblMembershipSubscription.MembershipPlanId = tblMembershipPlans.MembershipPlanId
    LEFT JOIN tblMemberShift
        ON tblMember.MemberId = tblMemberShift.MemberId
    LEFT JOIN tblShift
        ON tblMemberShift.ShiftId = tblShift.ShiftId
    LEFT JOIN tblMemberDietAssignment
        ON tblMember.MemberId = tblMemberDietAssignment.MemberId
    LEFT JOIN tblDietPlans
        ON tblMemberDietAssignment.DietPlanId = tblDietPlans.DietPlanId
    LEFT JOIN tblLockerAllocation
        ON tblMember.MemberId = tblLockerAllocation.MemberId
    LEFT JOIN tblLocker
        ON tblLockerAllocation.LockerId = tblLocker.LockerId
    ORDER BY tblMember.MemberId;
END;
GO

