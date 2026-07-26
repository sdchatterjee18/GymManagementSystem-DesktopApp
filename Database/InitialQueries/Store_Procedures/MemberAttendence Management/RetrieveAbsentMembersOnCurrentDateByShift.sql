CREATE PROC spRetrieveAbsentMembersOnCurrentDateByShift
    @ShiftId INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @ShiftId IS NULL OR @ShiftId <= 0
    BEGIN
        SELECT 'Invalid ShiftId. Please provide a valid positive integer.' AS Message;
        RETURN;
    END;

    IF NOT EXISTS (SELECT 1 FROM tblShift WHERE ShiftId = @ShiftId)
    BEGIN
        SELECT 'ShiftId does not exist in tblShift.' AS Message;
        RETURN;
    END;
    SELECT DISTINCT
        m.MemberId,
        CONCAT(ISNULL(m.FirstName,''), ' ',
               ISNULL(m.MiddleName,''), ' ',
               ISNULL(m.LastName,'')) AS MemberName,
        s.ShiftName,
        m.PhoneNo
    FROM tblShift s
    INNER JOIN tblMemberShift ms
        ON ms.ShiftId = s.ShiftId
        AND ms.IsActive = 1
    INNER JOIN tblMember m
        ON m.MemberId = ms.MemberId
        AND m.IsActive = 1
    LEFT JOIN tblMemberAttendance ma
        ON ma.MemberId = m.MemberId
        AND ma.ShiftId = s.ShiftId
        AND CAST(ma.AttendanceDate AS DATE) = CAST(GETDATE() AS DATE)
    WHERE ms.ShiftId = @ShiftId
      AND ma.AttendanceId IS NULL;
END;
