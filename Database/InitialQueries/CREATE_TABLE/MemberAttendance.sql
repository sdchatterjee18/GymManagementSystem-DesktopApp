CREATE TABLE tblMemberAttendance (
    AttendanceId INT  PRIMARY KEY IDENTITY(1,1) NOT NULL,
    MemberId INT NOT NULL,
    ShiftId INT NOT NULL,
    AttendanceDate DATETIME NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_tblMemberAttendance_MemberIdtblMember
		FOREIGN KEY (MemberId)
		REFERENCES tblMember(MemberId),
    CONSTRAINT FK_tblMemberAttendance_ShiftIdtblShift 
		FOREIGN KEY (ShiftId)
		REFERENCES tblShift(ShiftId)
);