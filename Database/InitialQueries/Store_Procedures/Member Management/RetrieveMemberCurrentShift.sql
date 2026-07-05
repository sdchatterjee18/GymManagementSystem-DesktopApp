CREATE PROC spRetrieveMemberCurrentShift
(
    @MemberId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Member Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
        )
        BEGIN
            SELECT 'Invalid Member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Active Shift Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMemberShift
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'No Active Shift Assigned To This Member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Retrieve Current Active Shift
        ------------------------------------------------
        SELECT
            M.MemberId,
            CONCAT(M.FirstName,' ',
                   ISNULL(M.MiddleName + ' ',''),
                   M.LastName) AS MemberName,
            S.ShiftId,
            S.ShiftName,
            S.StartTime,
            S.EndTime
        FROM tblMember M
        INNER JOIN tblMemberShift MS
            ON M.MemberId = MS.MemberId
        INNER JOIN tblShift S
            ON MS.ShiftId = S.ShiftId
        WHERE M.MemberId = @MemberId
          AND MS.IsActive = 1;

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO