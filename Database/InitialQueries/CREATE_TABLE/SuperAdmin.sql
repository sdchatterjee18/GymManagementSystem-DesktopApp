create table tblSuperAdmin(SuperAdminId int primary key not null identity(1,1),
UserName varchar(100) unique not null,
PasswordHash varchar(255) not null,
Email_Id varchar(150) unique not null,
PhoneNumber varchar(20),
LastLogin datetime,
IsActive bit default(1) not null,
CreatedAt datetime DEFAULT(GETDATE()) not null)