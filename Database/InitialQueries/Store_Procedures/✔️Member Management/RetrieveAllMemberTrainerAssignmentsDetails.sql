CREATE PROC spRetrieveAllMemberTrainerAssignmentsDetails
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        CONCAT(
            m.FirstName+' ', 
            ISNULL(m.MiddleName + ' ', ''), 
            m.LastName
        ) AS MemberName,
        m.PhoneNo,
        CONCAT(
            e.FirstName+' ', 
            ISNULL(e.MiddleName + ' ', ''), 
            e.LastName
        ) AS TrainerName
    FROM tblMemberTrainerAssignment mta
    JOIN tblMember m 
        ON mta.MemberId = m.MemberId
        AND mta.IsActive = 1
    JOIN tblTrainer t 
        ON mta.TrainerId = t.TrainerId
        AND t.IsActive = 1 
    JOIN tblEmployee e 
        ON t.EmployeeId = e.EmployeeId
        AND e.IsActive = 1 
    ORDER BY mta.MemberTrainerAssignmentId;
END