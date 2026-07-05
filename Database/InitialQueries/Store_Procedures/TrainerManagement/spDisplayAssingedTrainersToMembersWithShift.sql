
CREATE PROCEDURE spDisplayAssingedTrainersToMembersWithShift
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT 
    MTA.MemberTrainerAssignmentId,
    M.FirstName+' '+M.LastName As MemberName,
    Employee.FirstName+' '+Employee.LastName As TrainerName,
    T.TrainerType,
    Sh.ShiftName,
    Sh.StartTime,
    Sh.EndTime 
    FROM tblMemberTrainerAssignment AS MTA
    INNER JOIN tblMember AS M
    ON MTA.MemberId = M.MemberId
    INNER JOIN tblShift AS Sh 
    ON M.MemberId=Sh.ShiftId
    INNER JOIN tblTrainer AS T
    ON MTA.TrainerId = T.TrainerId
    INNER JOIN tblEmployee AS Employee 
    ON T.EmployeeId = Employee.EmployeeId
    WHERE T.TrainerType = 'Personal Trainer';

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_SEVERITY() AS ErrorSeverity,
            ERROR_STATE() AS ErrorState,
            ERROR_PROCEDURE() AS ErrorProcedure,
            ERROR_LINE() AS ErrorLine,
            ERROR_MESSAGE() AS ErrorMessage;

    END CATCH
END;
GO