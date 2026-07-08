CREATE PROCEDURE spDisplayMembersWithPersonalTrainer
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            M.MemberId,
            M.FirstName + ' ' + M.LastName AS MemberName,
            E.FirstName + ' ' + E.LastName AS TrainerName,
            T.TrainerType,
            Sh.StartTime,
            Sh.EndTime
        FROM tblMemberTrainerAssignment AS MTA
        INNER JOIN tblMember AS M
            ON MTA.MemberId = M.MemberId
            
        INNER JOIN tblTrainer AS T
            ON MTA.TrainerId = T.TrainerId
        INNER JOIN tblShift AS Sh
            ON Sh.ShiftId=T.TrainerId
        INNER JOIN tblEmployee AS E
            ON T.EmployeeId = E.EmployeeId
        WHERE T.TrainerType = 'Personal Trainer';

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END;
GO