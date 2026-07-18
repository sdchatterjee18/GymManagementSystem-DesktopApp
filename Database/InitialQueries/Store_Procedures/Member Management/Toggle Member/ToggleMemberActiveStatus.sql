CREATE PROC spToggleMemberActiveStatus
(
    @MemberId INT
)
AS
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
    )
    BEGIN
        SELECT 'Invalid Member Id.' AS Message;
        RETURN;
    END
    UPDATE tblMember
    SET IsActive =
        CASE
            WHEN IsActive = 1 THEN 0
            ELSE 1
        END
    WHERE MemberId = @MemberId;
    SELECT
        'Member Status Updated Successfully.' AS Message,
        MemberId,
        IsActive
    FROM tblMember
    WHERE MemberId = @MemberId;
END
GO