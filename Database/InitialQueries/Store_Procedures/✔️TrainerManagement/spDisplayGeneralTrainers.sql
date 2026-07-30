CREATE PROCEDURE DisplayGeneralTrainers
AS
BEGIN
	BEGIN TRY
		SELECT 
		CONCAT(E.FirstName,' ',E.MiddleName,' ',E.LastName) AS TrainerName,
		T.Specialization,
		E.PhoneNo,
		G.GenderName
		FROM tblTrainer T
		INNER JOIN tblEmployee E
		ON T.EmployeeId=E.EmployeeId
		INNER JOIN tblGender G 
		ON E.GenderId = G.GenderId 
		WHERE T.TrainerType='General' 
		AND E.IsActive=1;
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS Message;
	END CATCH
END