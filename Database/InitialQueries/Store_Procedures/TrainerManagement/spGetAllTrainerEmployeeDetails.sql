CREATE PROC spGetAllTrainerEmployeeDetails
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblEmployee E
            INNER JOIN tblEmployeeRoleType ERT
                ON E.RoleId = ERT.RoleId
            WHERE ERT.Role = 'Trainer'
        )
        BEGIN
            SELECT 'No Trainer Records Found.' AS Message;
            RETURN;
        END

        SELECT
            E.EmployeeId,
            E.FirstName,
            E.MiddleName,
            E.LastName,
            E.PhoneNo,
            E.EmailId,
            E.BankAccountNo,
            E.JoiningDate,
            E.IsActive AS EmployeeStatus,

            
            ERT.Role,

            T.TrainerId,
            T.Specialization,
            T.TrainerType,
            T.IsActive AS TrainerStatus,

           
            CD.Document

        FROM tblEmployee E

        INNER JOIN tblEmployeeRoleType ERT
            ON E.RoleId = ERT.RoleId

        INNER JOIN tblTrainer T
            ON E.EmployeeId = T.EmployeeId

        LEFT JOIN tblCertificateDocument CD
            ON T.TrainerId = CD.TrainerId

        WHERE ERT.Role = 'Trainer'

        ORDER BY
            E.FirstName,
            E.LastName;

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS ErrorMessage,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ErrorProcedure;

    END CATCH
END
GO

EXEC spGetAllTrainerEmployeeDetails