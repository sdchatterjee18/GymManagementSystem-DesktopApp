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
            T.TrainerId,
            CONCAT(E.FirstName,' ',E.MiddleName, ' ',E.LastName) AS TrainerName,
            T.Specialization,
            T.TrainerType,
            CD.Document,
            E.PhoneNo,
            G.GenderName AS Gender

        FROM tblEmployee E

        INNER JOIN tblEmployeeRoleType ERT
            ON E.RoleId = ERT.RoleId

        INNER JOIN tblTrainer T
            ON E.EmployeeId = T.EmployeeId

        LEFT JOIN tblCertificateDocument CD
            ON T.TrainerId = CD.TrainerId

        INNER JOIN tblGender G
            ON E.GenderId = G.GenderId

        WHERE ERT.Role = 'Trainer' AND E.IsActive=1

        ORDER BY
            E.FirstName,
            E.LastName;
            
    END TRY

    BEGIN CATCH
            SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO
