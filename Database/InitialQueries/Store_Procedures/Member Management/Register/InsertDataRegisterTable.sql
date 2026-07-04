-- 1 (Locker)
EXEC spRegisterNewMember
@FirstName='Amit',
@MiddleName='Kumar',
@LastName='Sharma',
@GenderId=1,
@PhoneNo='9000000001',
@EmailId='amit1@gmail.com',
@City='Kolkata',
@District='Kolkata',
@State='West Bengal',
@EmergencyContact='9000001001',
@ProfilePhoto=NULL,
@MembershipPlanId=1,
@PaymentMethod='Cash',
@FeesType='Monthly',
@ShiftId=1,
@DietPlanId=1,
@NeedLocker=1;
GO

-- 2 (No Locker)
EXEC spRegisterNewMember
@FirstName='Priya',
@MiddleName='Rani',
@LastName='Das',
@GenderId=2,
@PhoneNo='9000000002',
@EmailId='priya2@gmail.com',
@City='Howrah',
@District='Howrah',
@State='West Bengal',
@EmergencyContact='9000001002',
@ProfilePhoto=NULL,
@MembershipPlanId=2,
@PaymentMethod='UPI',
@FeesType='Monthly',
@ShiftId=2,
@DietPlanId=2,
@NeedLocker=0;
GO

-- 3 (Locker)
EXEC spRegisterNewMember
@FirstName='Rahul',
@MiddleName=NULL,
@LastName='Roy',
@GenderId=1,
@PhoneNo='9000000003',
@EmailId='rahul3@gmail.com',
@City='Durgapur',
@District='Paschim Bardhaman',
@State='West Bengal',
@EmergencyContact='9000001003',
@ProfilePhoto=NULL,
@MembershipPlanId=3,
@PaymentMethod='Card',
@FeesType='Quarterly',
@ShiftId=1,
@DietPlanId=3,
@NeedLocker=1;
GO

-- 4 (No Locker)
EXEC spRegisterNewMember
@FirstName='Sneha',
@MiddleName=NULL,
@LastName='Paul',
@GenderId=2,
@PhoneNo='9000000004',
@EmailId='sneha4@gmail.com',
@City='Siliguri',
@District='Darjeeling',
@State='West Bengal',
@EmergencyContact='9000001004',
@ProfilePhoto=NULL,
@MembershipPlanId=1,
@PaymentMethod='Cash',
@FeesType='Yearly',
@ShiftId=3,
@DietPlanId=1,
@NeedLocker=0;
GO

-- 5 (Locker)
EXEC spRegisterNewMember
@FirstName='Sourav',
@MiddleName='K',
@LastName='Dey',
@GenderId=1,
@PhoneNo='9000000005',
@EmailId='sourav5@gmail.com',
@City='Kharagpur',
@District='Paschim Medinipur',
@State='West Bengal',
@EmergencyContact='9000001005',
@ProfilePhoto=NULL,
@MembershipPlanId=2,
@PaymentMethod='Card',
@FeesType='Monthly',
@ShiftId=2,
@DietPlanId=2,
@NeedLocker=1;
GO

-- 6 (No Locker)
EXEC spRegisterNewMember
@FirstName='Riya',
@MiddleName=NULL,
@LastName='Sen',
@GenderId=2,
@PhoneNo='9000000006',
@EmailId='riya6@gmail.com',
@City='Asansol',
@District='Paschim Bardhaman',
@State='West Bengal',
@EmergencyContact='9000001006',
@ProfilePhoto=NULL,
@MembershipPlanId=3,
@PaymentMethod='UPI',
@FeesType='Quarterly',
@ShiftId=1,
@DietPlanId=4,
@NeedLocker=0;
GO

-- 7 (Locker)
EXEC spRegisterNewMember
@FirstName='Ankit',
@MiddleName=NULL,
@LastName='Mondal',
@GenderId=1,
@PhoneNo='9000000007',
@EmailId='ankit7@gmail.com',
@City='Malda',
@District='Malda',
@State='West Bengal',
@EmergencyContact='9000001007',
@ProfilePhoto=NULL,
@MembershipPlanId=1,
@PaymentMethod='Cash',
@FeesType='Monthly',
@ShiftId=2,
@DietPlanId=1,
@NeedLocker=1;
GO

-- 8 (No Locker)
EXEC spRegisterNewMember
@FirstName='Mousumi',
@MiddleName='R',
@LastName='Ghosh',
@GenderId=2,
@PhoneNo='9000000008',
@EmailId='mousumi8@gmail.com',
@City='Hooghly',
@District='Hooghly',
@State='West Bengal',
@EmergencyContact='9000001008',
@ProfilePhoto=NULL,
@MembershipPlanId=2,
@PaymentMethod='Card',
@FeesType='Yearly',
@ShiftId=3,
@DietPlanId=2,
@NeedLocker=0;
GO

-- 9 (Locker)
EXEC spRegisterNewMember
@FirstName='Debasis',
@MiddleName=NULL,
@LastName='Saha',
@GenderId=1,
@PhoneNo='9000000009',
@EmailId='debasis9@gmail.com',
@City='Nadia',
@District='Nadia',
@State='West Bengal',
@EmergencyContact='9000001009',
@ProfilePhoto=NULL,
@MembershipPlanId=3,
@PaymentMethod='Cash',
@FeesType='Quarterly',
@ShiftId=1,
@DietPlanId=3,
@NeedLocker=1;
GO

-- 10 (Locker)
EXEC spRegisterNewMember
@FirstName='Puja',
@MiddleName=NULL,
@LastName='Chatterjee',
@GenderId=2,
@PhoneNo='9000000010',
@EmailId='puja10@gmail.com',
@City='Bardhaman',
@District='Purba Bardhaman',
@State='West Bengal',
@EmergencyContact='9000001010',
@ProfilePhoto=NULL,
@MembershipPlanId=1,
@PaymentMethod='UPI',
@FeesType='Monthly',
@ShiftId=2,
@DietPlanId=4,
@NeedLocker=1;
GO
