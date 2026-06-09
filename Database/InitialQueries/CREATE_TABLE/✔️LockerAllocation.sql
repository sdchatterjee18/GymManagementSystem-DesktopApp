CREATE TABLE tblLockerAllocation
(
    LockerAllocationId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    LockerId INT NOT NULL,
    MemberId INT NOT NULL,

    CONSTRAINT FK_tblLockerAllocation_LockerIdtblLocker
        FOREIGN KEY (LockerId)
        REFERENCES tblLocker(LockerId),

    CONSTRAINT FK_tblLockerAllocation_MemberIdtblMember
        FOREIGN KEY (MemberId)
        REFERENCES tblMember(MemberId)
);