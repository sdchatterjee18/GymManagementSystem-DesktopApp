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
            CONCAT(E.FirstName,' ',E.MiddleName, ' ',E.LastName) AS TrainerName,

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
            ERROR_MESSAGE() AS ErrorMessage
    END CATCH
END
GO
