CREATE PROC spInsertDataIntoLockerAllocationTable
(
    @LockerId INT,
    @MemberId INT
)
AS
BEGIN
BEGIN TRY

    IF @LockerId IS NULL
    BEGIN
        SELECT 'Locker Id is Required.' AS Message
        RETURN
    END

    IF @MemberId IS NULL
    BEGIN
        SELECT 'Member Id is Required.' AS Message
        RETURN
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblLocker
        WHERE LockerId = @LockerId
    )
    BEGIN
        SELECT 'Invalid Locker Id.' AS Message
        RETURN
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
    )
    BEGIN
        SELECT 'Invalid Member Id.' AS Message
        RETURN
    END

    IF EXISTS
    (
        SELECT 1
        FROM tblLockerAllocation
        WHERE LockerId = @LockerId
    )
    BEGIN
        SELECT 'Locker Is Already Allocated To A Member.' AS Message
        RETURN
    END

    IF EXISTS
    (
        SELECT 1
        FROM tblLockerAllocation
        WHERE MemberId = @MemberId
    )
    BEGIN
        SELECT 'Member Already Has An Active Locker Allocation.' AS Message
        RETURN
    END

    INSERT INTO tblLockerAllocation
    (
        LockerId,
        MemberId
    )
    VALUES
    (
        @LockerId,
        @MemberId
    )

    UPDATE tblLocker
    SET LockerStatus = 'Occupied'
    WHERE LockerId = @LockerId;

    SELECT 'Locker Allocated Successfully.' AS Message

END TRY
BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName

END CATCH
END
GO