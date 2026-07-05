EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 2,
    @TrainerType = 'Personal Trainer',
    @Specialization = 'Weight Loss',
    @JoiningDate = '2026-07-10' ,
    @IsActive =1;
EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 3,
    @TrainerType = 'Personal Trainer',
    @Specialization = 'Yoga',
    @JoiningDate = '2026-07-10',@IsActive=1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 4,
    @TrainerType = 'Genaral Trainer',
    @Specialization = 'Cardio Fitness',
    @JoiningDate = '2026-08-10',@IsActive=1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 5,
    @TrainerType = 'Personal Trainer',
    @Specialization = 'Muscle Building',
    @JoiningDate = '2026-09-10',@IsActive=1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 6,
    @TrainerType = 'Genaral Trainer',
    @Specialization = 'CrossFit',
    @JoiningDate = '2026-10-10',@IsActive=1;