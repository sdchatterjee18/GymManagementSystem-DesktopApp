CREATE TABLE tblMemberShift
(
	MemberShiftId INT PRIMARY KEY IDENTITY(1,1),
	MemberId INT NOT NULL,  
	ShiftId INT NOT NULL,
	IsActive BIT DEFAULT(1),

	CONSTRAINT FK_tblMemberShift_MemberIdtblMember 
	  FOREIGN KEY(MemberId) 
	  REFERENCES tblMember(MemberId) ,
	CONSTRAINT FK_tblMemberShift_ShiftIdtblShift
	  FOREIGN KEY(ShiftId)
	  REFERENCES tblShift(ShiftId) 
);

