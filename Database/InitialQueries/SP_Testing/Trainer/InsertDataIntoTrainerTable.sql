CREATE PROC spInsertDataIntoTrainerTable  
(  
    @EmployeeId INT,  
    @TrainerType VARCHAR(100),  
    @Specialization VARCHAR(100),  
    @JoiningDate DATE,  
    @IsActive BIT  
)  
AS  
BEGIN  
   BEGIN TRY  
    IF NOT EXISTS  
    (  
        SELECT 1  
        FROM tblEmployee  
        WHERE EmployeeId = @EmployeeId  
    )  
    BEGIN  
        RAISERROR('Employee does not exist.',16,1)  
        RETURN  
    END  
  
    IF @TrainerType IS NULL  
       OR LTRIM(RTRIM(@TrainerType)) = ''  
    BEGIN  
        RAISERROR('Trainer Type is required.',16,1)  
        RETURN  
    END  
  
    IF @Specialization IS NULL  
       OR LTRIM(RTRIM(@Specialization)) = ''  
    BEGIN  
        RAISERROR('Specialization is required.',16,1)  
        RETURN  
    END  
  
    IF @JoiningDate IS NULL  
    BEGIN  
        RAISERROR('Joining Date is required.',16,1)  
        RETURN  
    END  
  
    IF @JoiningDate < GETDATE()  
    BEGIN  
        RAISERROR('Joining Date cannot be a past date.',16,1)  
        RETURN  
    END  
  
    IF EXISTS  
    (  
        SELECT 1  
        FROM tblTrainer  
        WHERE EmployeeId = @EmployeeId  
    )  
    BEGIN  
        RAISERROR('Trainer already exists for this Employee.',16,1)  
        RETURN  
    END  
  
    INSERT INTO tblTrainer  
    (  
        EmployeeId,  
        TrainerType,  
        Specialization,  
        JoiningDate,  
        IsActive  
    )  
    VALUES  
    (  
        @EmployeeId,  
        @TrainerType,  
        @Specialization,  
        @JoiningDate,  
        @IsActive  
    )  
  
    PRINT 'Trainer Inserted Successfully'  
   END TRY  
   BEGIN CATCH  
        SELECT ERROR_MESSAGE() AS ERRORMESSAGE;  
  SELECT ERROR_NUMBER() AS ERRORNUMBER;  
  SELECT ERROR_LINE () AS ERRORLINE;  
  SELECT ERROR_PROCEDURE() AS ERRORPROCEDURE;  
   END CATCH  
END  