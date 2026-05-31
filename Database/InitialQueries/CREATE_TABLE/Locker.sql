create table tblLocker(LockerId int primary key not null identity(1,1),
LockerNo varchar(20) unique not null,
LockerStatus varchar(50) not null DEFAULT('Available'))
