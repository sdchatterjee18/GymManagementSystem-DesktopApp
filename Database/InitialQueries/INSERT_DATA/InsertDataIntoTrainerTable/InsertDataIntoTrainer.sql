EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 1,
    @TrainerType = 'Personal Trainer',
    @Specialization = 'Weight Loss',
    @JoiningDate = '2026-06-05',
    @IsActive = 1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 2,
    @TrainerType = 'Yoga Trainer',
    @Specialization = 'Yoga',
    @JoiningDate = '2026-06-06',
    @IsActive = 1;
    select * from tblTrainer
EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 3,
    @TrainerType = 'Cardio Trainer',
    @Specialization = 'Cardio Fitness',
    @JoiningDate = '2026-06-07',
    @IsActive = 1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 4,
    @TrainerType = 'Strength Trainer',
    @Specialization = 'Muscle Building',
    @JoiningDate = '2026-06-08',
    @IsActive = 1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 5,
    @TrainerType = 'CrossFit Trainer',
    @Specialization = 'CrossFit',
    @JoiningDate = '2026-06-09',
    @IsActive = 1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 6,
    @TrainerType = 'Nutrition Trainer',
    @Specialization = 'Diet Planning',
    @JoiningDate = '2026-06-10',
    @IsActive = 1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 7,
    @TrainerType = 'Zumba Trainer',
    @Specialization = 'Zumba Dance',
    @JoiningDate = '2026-06-11',
    @IsActive = 1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 8,
    @TrainerType = 'Physiotherapy Trainer',
    @Specialization = 'Rehabilitation',
    @JoiningDate = '2026-06-12',
    @IsActive = 1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 9,
    @TrainerType = 'Sports Trainer',
    @Specialization = 'Athletic Training',
    @JoiningDate = '2026-06-13',
    @IsActive = 1;

EXEC spInsertDataIntoTrainerTable
    @EmployeeId = 10,
    @TrainerType = 'Functional Trainer',
    @Specialization = 'Functional Fitness',
    @JoiningDate = '2026-06-14',
    @IsActive = 1;