CREATE PROCEDURE spDisplayAllDietPlans
AS
BEGIN
	BEGIN TRY
		SELECT 
		tblDietPlans.CaloriesPerDay,
		tblDietPlans.DietPlanDocument,
		tblDietPlans.ConditionStatus
		FROM tblDietPlans
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS Message
	END CATCH
END