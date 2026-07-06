CREATE  PROC spRetrieveActiveMembersByShift
(
    @ShiftId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @ShiftId
        )
        BEGIN
            RAISERROR('Invalid Shift.', 16, 1);
            RETURN;
        END;

        SELECT
            m.MemberId,
            CONCAT(m.FirstName, ' ', m.LastName) AS MemberName,
            m.PhoneNo,
            m.EmailId
        FROM tblMemberShift ms
        INNER JOIN tblMember m
            ON ms.MemberId = m.MemberId
        WHERE ms.ShiftId = @ShiftId
          AND ms.IsActive = 1
          AND m.IsActive = 1
        ORDER BY m.FirstName, m.LastName;

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO