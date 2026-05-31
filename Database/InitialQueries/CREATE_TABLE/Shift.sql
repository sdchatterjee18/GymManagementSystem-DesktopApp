
create table tblShift(
ShiftId int primary key not null identity(1,1),
ShiftName VARCHAR(100) UNIQUE not null,
StartTime TIME not null,
EndTime TIME not null
)