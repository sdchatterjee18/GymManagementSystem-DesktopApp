-- 1 (Locker)
EXEC spRegisterNewMember
@FirstName='Amit', @MiddleName='Kumar', @LastName='Sharma',
@GenderId=1, @PhoneNo='9000000001', @EmailId='amit1@gmail.com',
@City='Kolkata', @District='Kolkata', @State='West Bengal',
@EmergencyContact='9000001001',
@MembershipPlanId=1, @StartDate='2026-06-09', @ExpiryDate='2026-07-09',
@ShiftId=1, @DietPlanId=1,
@NeedLocker=1;

-- 2 (Locker)
EXEC spRegisterNewMember
@FirstName='Rahul', @MiddleName='Kumar', @LastName='Singh',
@GenderId=1, @PhoneNo='9000000002', @EmailId='rahul2@gmail.com',
@City='Howrah', @District='Howrah', @State='West Bengal',
@EmergencyContact='9000001002',
@MembershipPlanId=2, @StartDate='2026-06-09', @ExpiryDate='2026-09-09',
@ShiftId=2, @DietPlanId=2,
@NeedLocker=1;

-- 3 (No Locker)
EXEC spRegisterNewMember
@FirstName='Priya', @MiddleName='Rani', @LastName='Das',
@GenderId=2, @PhoneNo='9000000003', @EmailId='priya3@gmail.com',
@City='Kolkata', @District='Kolkata', @State='West Bengal',
@EmergencyContact='9000001003',
@MembershipPlanId=1, @StartDate='2026-06-09', @ExpiryDate='2026-07-09',
@ShiftId=1, @DietPlanId=3,
@NeedLocker=0;

-- 4 (Locker)
EXEC spRegisterNewMember
@FirstName='Sneha', @MiddleName='K', @LastName='Roy',
@GenderId=2, @PhoneNo='9000000004', @EmailId='sneha4@gmail.com',
@City='Durgapur', @District='Paschim Bardhaman', @State='West Bengal',
@EmergencyContact='9000001004',
@MembershipPlanId=2, @StartDate='2026-06-09', @ExpiryDate='2026-09-09',
@ShiftId=2, @DietPlanId=1,
@NeedLocker=1;

-- 5 (Locker)
EXEC spRegisterNewMember
@FirstName='Arjun', @MiddleName='K', @LastName='Paul',
@GenderId=1, @PhoneNo='9000000005', @EmailId='arjun5@gmail.com',
@City='Siliguri', @District='Darjeeling', @State='West Bengal',
@EmergencyContact='9000001005',
@MembershipPlanId=3, @StartDate='2026-06-09', @ExpiryDate='2026-12-09',
@ShiftId=3, @DietPlanId=2,
@NeedLocker=1;

-- 6 (No Locker)
EXEC spRegisterNewMember
@FirstName='Riya', @MiddleName='M', @LastName='Ghosh',
@GenderId=2, @PhoneNo='9000000006', @EmailId='riya6@gmail.com',
@City='Kalyani', @District='Nadia', @State='West Bengal',
@EmergencyContact='9000001006',
@MembershipPlanId=1, @StartDate='2026-06-09', @ExpiryDate='2026-07-09',
@ShiftId=1, @DietPlanId=1,
@NeedLocker=0;

-- 7 (Locker)
EXEC spRegisterNewMember
@FirstName='Sourav', @MiddleName='K', @LastName='Dey',
@GenderId=1, @PhoneNo='9000000007', @EmailId='sourav7@gmail.com',
@City='Barrackpore', @District='North 24 Parganas', @State='West Bengal',
@EmergencyContact='9000001007',
@MembershipPlanId=2, @StartDate='2026-06-09', @ExpiryDate='2026-09-09',
@ShiftId=2, @DietPlanId=2,
@NeedLocker=1;

-- 8 (Locker)
EXEC spRegisterNewMember
@FirstName='Puja', @MiddleName='R', @LastName='Sen',
@GenderId=2, @PhoneNo='9000000008', @EmailId='puja8@gmail.com',
@City='Hooghly', @District='Hooghly', @State='West Bengal',
@EmergencyContact='9000001008',
@MembershipPlanId=3, @StartDate='2026-06-09', @ExpiryDate='2026-12-09',
@ShiftId=3, @DietPlanId=3,
@NeedLocker=1;

-- 9 (No Locker)
EXEC spRegisterNewMember
@FirstName='Ankit', @MiddleName='K', @LastName='Verma',
@GenderId=1, @PhoneNo='9000000009', @EmailId='ankit9@gmail.com',
@City='Asansol', @District='Paschim Bardhaman', @State='West Bengal',
@EmergencyContact='9000001009',
@MembershipPlanId=1, @StartDate='2026-06-09', @ExpiryDate='2026-07-09',
@ShiftId=1, @DietPlanId=1,
@NeedLocker=0;

-- 10 (Locker)
EXEC spRegisterNewMember
@FirstName='Mousumi', @MiddleName='R', @LastName='Mondal',
@GenderId=2, @PhoneNo='9000000010', @EmailId='mousumi10@gmail.com',
@City='Kolkata', @District='Kolkata', @State='West Bengal',
@EmergencyContact='9000001010',
@MembershipPlanId=2, @StartDate='2026-06-09', @ExpiryDate='2026-09-09',
@ShiftId=2, @DietPlanId=2,
@NeedLocker=1;

-- 11 (Locker)
EXEC spRegisterNewMember
@FirstName='Rakesh', @MiddleName='Kumar', @LastName='Das',
@GenderId=1, @PhoneNo='9100000001', @EmailId='rakesh1@gmail.com',
@City='Kolkata', @District='Kolkata', @State='West Bengal',
@EmergencyContact='9100001001',
@MembershipPlanId=1, @StartDate='2026-06-10', @ExpiryDate='2026-07-10',
@ShiftId=1, @DietPlanId=1,
@NeedLocker=1;

-- 12 (No Locker)
EXEC spRegisterNewMember
@FirstName='Ananya', @MiddleName='R', @LastName='Sen',
@GenderId=2, @PhoneNo='9100000002', @EmailId='ananya2@gmail.com',
@City='Howrah', @District='Howrah', @State='West Bengal',
@EmergencyContact='9100001002',
@MembershipPlanId=2, @StartDate='2026-06-10', @ExpiryDate='2026-09-10',
@ShiftId=2, @DietPlanId=2,
@NeedLocker=0;

-- 13 (Locker)
EXEC spRegisterNewMember
@FirstName='Suman', @MiddleName='K', @LastName='Roy',
@GenderId=1, @PhoneNo='9100000003', @EmailId='suman3@gmail.com',
@City='Durgapur', @District='Paschim Bardhaman', @State='West Bengal',
@EmergencyContact='9100001003',
@MembershipPlanId=1, @StartDate='2026-06-10', @ExpiryDate='2026-07-10',
@ShiftId=1, @DietPlanId=3,
@NeedLocker=1;

-- 14 (Locker)
EXEC spRegisterNewMember
@FirstName='Madhumita', @MiddleName='P', @LastName='Ghosh',
@GenderId=2, @PhoneNo='9100000004', @EmailId='madhumita4@gmail.com',
@City='Siliguri', @District='Darjeeling', @State='West Bengal',
@EmergencyContact='9100001004',
@MembershipPlanId=3, @StartDate='2026-06-10', @ExpiryDate='2026-12-10',
@ShiftId=3, @DietPlanId=1,
@NeedLocker=1;

-- 15 (No Locker)
EXEC spRegisterNewMember
@FirstName='Abhishek', @MiddleName='K', @LastName='Paul',
@GenderId=1, @PhoneNo='9100000005', @EmailId='abhishek5@gmail.com',
@City='Kalyani', @District='Nadia', @State='West Bengal',
@EmergencyContact='9100001005',
@MembershipPlanId=2, @StartDate='2026-06-10', @ExpiryDate='2026-09-10',
@ShiftId=2, @DietPlanId=2,
@NeedLocker=0;

-- 16 (Locker)
EXEC spRegisterNewMember
@FirstName='Debasish',
@MiddleName='K',
@LastName='Saha',
@GenderId=1,
@PhoneNo='9200000001',
@EmailId='debasish16@gmail.com',
@City='Kolkata',
@District='Kolkata',
@State='West Bengal',
@EmergencyContact='9200001001',
@MembershipPlanId=1,
@StartDate='2026-06-10',
@ExpiryDate='2026-07-10',
@ShiftId=1,
@DietPlanId=1,
@NeedLocker=1;

-- 17 (Locker)
EXEC spRegisterNewMember
@FirstName='Nikita',
@MiddleName='R',
@LastName='Dutta',
@GenderId=2,
@PhoneNo='9200000002',
@EmailId='nikita17@gmail.com',
@City='Howrah',
@District='Howrah',
@State='West Bengal',
@EmergencyContact='9200001002',
@MembershipPlanId=2,
@StartDate='2026-06-10',
@ExpiryDate='2026-09-10',
@ShiftId=2,
@DietPlanId=2,
@NeedLocker=1;

-- 18 (No Locker)
EXEC spRegisterNewMember
@FirstName='Tanmoy',
@MiddleName='K',
@LastName='Ghosh',
@GenderId=1,
@PhoneNo='9200000003',
@EmailId='tanmoy18@gmail.com',
@City='Durgapur',
@District='Paschim Bardhaman',
@State='West Bengal',
@EmergencyContact='9200001003',
@MembershipPlanId=1,
@StartDate='2026-06-10',
@ExpiryDate='2026-07-10',
@ShiftId=1,
@DietPlanId=3,
@NeedLocker=0;

-- 19 (Locker)
EXEC spRegisterNewMember
@FirstName='Pallabi',
@MiddleName='M',
@LastName='Roy',
@GenderId=2,
@PhoneNo='9200000004',
@EmailId='pallabi19@gmail.com',
@City='Siliguri',
@District='Darjeeling',
@State='West Bengal',
@EmergencyContact='9200001004',
@MembershipPlanId=3,
@StartDate='2026-06-10',
@ExpiryDate='2026-12-10',
@ShiftId=3,
@DietPlanId=1,
@NeedLocker=1;

-- 20 (Locker)
EXEC spRegisterNewMember
@FirstName='Biswajit',
@MiddleName='K',
@LastName='Mondal',
@GenderId=1,
@PhoneNo='9200000005',
@EmailId='biswajit20@gmail.com',
@City='Kalyani',
@District='Nadia',
@State='West Bengal',
@EmergencyContact='9200001005',
@MembershipPlanId=2,
@StartDate='2026-06-10',
@ExpiryDate='2026-09-10',
@ShiftId=2,
@DietPlanId=2,
@NeedLocker=1;

-- 21 (No Locker)
EXEC spRegisterNewMember
@FirstName='Mita',
@MiddleName='R',
@LastName='Chatterjee',
@GenderId=2,
@PhoneNo='9200000006',
@EmailId='mita21@gmail.com',
@City='Hooghly',
@District='Hooghly',
@State='West Bengal',
@EmergencyContact='9200001006',
@MembershipPlanId=1,
@StartDate='2026-06-10',
@ExpiryDate='2026-07-10',
@ShiftId=1,
@DietPlanId=1,
@NeedLocker=0;

-- 22 (Locker)
EXEC spRegisterNewMember
@FirstName='Subham',
@MiddleName='K',
@LastName='Paul',
@GenderId=1,
@PhoneNo='9200000007',
@EmailId='subham22@gmail.com',
@City='Barrackpore',
@District='North 24 Parganas',
@State='West Bengal',
@EmergencyContact='9200001007',
@MembershipPlanId=2,
@StartDate='2026-06-10',
@ExpiryDate='2026-09-10',
@ShiftId=2,
@DietPlanId=2,
@NeedLocker=1;

-- 23 (Locker)
EXEC spRegisterNewMember
@FirstName='Rupa',
@MiddleName='S',
@LastName='Sen',
@GenderId=2,
@PhoneNo='9200000008',
@EmailId='rupa23@gmail.com',
@City='Asansol',
@District='Paschim Bardhaman',
@State='West Bengal',
@EmergencyContact='9200001008',
@MembershipPlanId=3,
@StartDate='2026-06-10',
@ExpiryDate='2026-12-10',
@ShiftId=3,
@DietPlanId=3,
@NeedLocker=1;

-- 24 (No Locker)
EXEC spRegisterNewMember
@FirstName='Kaushik',
@MiddleName='K',
@LastName='Das',
@GenderId=1,
@PhoneNo='9200000009',
@EmailId='kaushik24@gmail.com',
@City='Kolkata',
@District='Kolkata',
@State='West Bengal',
@EmergencyContact='9200001009',
@MembershipPlanId=1,
@StartDate='2026-06-10',
@ExpiryDate='2026-07-10',
@ShiftId=1,
@DietPlanId=1,
@NeedLocker=0;

-- 25 (Locker)
EXEC spRegisterNewMember
@FirstName='Sweta',
@MiddleName='R',
@LastName='Banerjee',
@GenderId=2,
@PhoneNo='9200000010',
@EmailId='sweta25@gmail.com',
@City='Kolkata',
@District='Kolkata',
@State='West Bengal',
@EmergencyContact='9200001010',
@MembershipPlanId=2,
@StartDate='2026-06-10',
@ExpiryDate='2026-09-10',
@ShiftId=2,
@DietPlanId=2,
@NeedLocker=1;