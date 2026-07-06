CREATE PROC spRetrieveActiveMembersByShift
(
    @ShiftId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Shift Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @ShiftId
        )
        BEGIN
            SELECT 'Invalid Shift.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Retrieve Active Members
        ------------------------------------------------
        SELECT
            M.MemberId,
            CONCAT(M.FirstName, ' ', M.LastName) AS MemberName,
            M.PhoneNo,
            M.EmailId
        FROM tblMemberShift MS
        INNER JOIN tblMember M
            ON MS.MemberId = M.MemberId
        WHERE MS.ShiftId = @ShiftId
          AND MS.IsActive = 1
          AND M.IsActive = 1
        ORDER BY M.FirstName, M.LastName;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO