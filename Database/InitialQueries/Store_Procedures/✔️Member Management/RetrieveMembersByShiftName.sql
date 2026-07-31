CREATE PROC spRetrieveMembersByShiftName
(
    @ShiftName VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Validation
        ------------------------------------------------
        SET @ShiftName = LTRIM(RTRIM(@ShiftName));

        IF @ShiftName = ''
        BEGIN
            SELECT 'Shift Name is required.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Shift Exists
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftName = @ShiftName
        )
        BEGIN
            SELECT 'Shift not found.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Retrieve Active Members
        ------------------------------------------------
        SELECT
            M.MemberId,

            CONCAT
            (
                M.FirstName,
                CASE
                    WHEN M.MiddleName IS NULL
                         OR LTRIM(RTRIM(M.MiddleName)) = ''
                    THEN ' '
                    ELSE ' ' + M.MiddleName + ' '
                END,
                M.LastName
            ) AS MemberName,

            M.PhoneNo,
            M.EmailId,

            CONCAT
            (
                M.City,
                ', ',
                M.District,
                ', ',
                M.State
            ) AS Address,

            M.EmergencyContact,
            M.JoiningDate

        FROM tblMember AS M
        INNER JOIN tblMemberShift AS MS
            ON M.MemberId = MS.MemberId
        INNER JOIN tblShift AS S
            ON MS.ShiftId = S.ShiftId

        WHERE
            S.ShiftName = @ShiftName
            AND MS.IsActive = 1
            AND M.IsActive = 1

        ORDER BY
            MemberName;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO