CREATE PROC spRetrieveMemberAttendanceCountByMonth
(
    @MemberId INT,
    @Month INT,
    @Year INT
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
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Invalid Member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Month Validation
        ------------------------------------------------
        IF @Month NOT BETWEEN 1 AND 12
        BEGIN
            SELECT 'Invalid Month.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Year Validation
        ------------------------------------------------
        IF @Year < 2000
        BEGIN
            SELECT 'Invalid Year.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Attendance Count
        ------------------------------------------------
        SELECT
            M.MemberId,
            M.FirstName + ' ' + ISNULL(M.MiddleName + ' ', '') + M.LastName AS MemberName,
            @Month AS [Month],
            @Year AS [Year],
            COUNT(DISTINCT CAST(MA.AttendanceDate AS DATE)) AS TotalAttendanceDays
        FROM tblMember M
        LEFT JOIN tblMemberAttendance MA
            ON M.MemberId = MA.MemberId
           AND MONTH(MA.AttendanceDate) = @Month
           AND YEAR(MA.AttendanceDate) = @Year
        WHERE M.MemberId = @MemberId
        GROUP BY
            M.MemberId,
            M.FirstName,
            M.MiddleName,
            M.LastName;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO