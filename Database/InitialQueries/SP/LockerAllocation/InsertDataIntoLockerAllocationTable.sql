CREATE PROC spInsertDataIntoLockerAllocationTable
(
    @LockerId INT,
    @MemberId INT,
    @ExpiryDate DATE
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
    IF @ExpiryDate IS NULL
    BEGIN
        SELECT 'Expiry Date is Required.' AS Message
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

    IF @ExpiryDate <= CAST(GETDATE() AS DATE)
    BEGIN
        SELECT 'Expiry Date Must Be Greater Than Today.' AS Message
        RETURN
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblLockerAllocation
        WHERE LockerId = @LockerId
          AND ExpiryDate >= CAST(GETDATE() AS DATE)
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
          AND ExpiryDate >= CAST(GETDATE() AS DATE)
    )
    BEGIN
        SELECT 'Member Already Has An Active Locker Allocation.' AS Message
        RETURN
    END
    INSERT INTO tblLockerAllocation
    (
        LockerId,
        MemberId,
        ExpiryDate
    )
    VALUES
    (
        @LockerId,
        @MemberId,
        @ExpiryDate
    )
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