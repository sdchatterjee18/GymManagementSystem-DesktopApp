CREATE PROC spGetLockerDetails
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        L.LockerId,
        L.LockerNo,
        ISNULL(
            M.FirstName +
            CASE 
                WHEN M.MiddleName IS NULL OR LTRIM(RTRIM(M.MiddleName)) = ''
                    THEN ' '
                ELSE ' ' + M.MiddleName + ' '
            END +
            M.LastName,
            ''
        ) AS MemberName,
        L.LockerStatus
    FROM tblLocker AS L
    LEFT JOIN tblLockerAllocation AS LA
        ON L.LockerId = LA.LockerId
    LEFT JOIN tblMember AS M
        ON LA.MemberId = M.MemberId
    ORDER BY L.LockerNo;
END;
GO