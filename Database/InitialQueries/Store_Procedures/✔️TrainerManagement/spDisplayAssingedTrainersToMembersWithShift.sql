
CREATE PROCEDURE spDisplayAssingedTrainersToMembersWithShift
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT 
    MTA.MemberTrainerAssignmentId,
    CONCAT(M.FirstName,' ',M.MiddleName,' ',M.LastName) As MemberName,
    CONCAT(Employee.FirstName,' ',Employee.MiddleName,' ',Employee.LastName) As TrainerName,
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
    WHERE T.TrainerType = 'Personal';

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO