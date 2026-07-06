CREATE PROC spInsertDietPlan
(
    @CaloriesPerDay INT,
    @DietPlanDocument VARBINARY(MAX) = NULL,
    @ConditionStatus VARCHAR(MAX)
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;

    -- Trim not applicable for INT/VARBINARY, only text
    SET @ConditionStatus = LTRIM(RTRIM(@ConditionStatus));

    -- Calories validation
    IF @CaloriesPerDay IS NULL
    BEGIN
        SELECT 'Calories Per Day is Required.' AS Message;
        RETURN;
    END

    IF @CaloriesPerDay <= 0
    BEGIN
        SELECT 'Calories Per Day Must Be Greater Than 0.' AS Message;
        RETURN;
    END

    -- Condition Status validation
    IF @ConditionStatus IS NULL OR @ConditionStatus = ''
    BEGIN
        SELECT 'Condition Status is Required.' AS Message;
        RETURN;
    END

    IF LEN(@ConditionStatus) < 3
    BEGIN
        SELECT 'Condition Status is Too Short.' AS Message;
        RETURN;
    END

    -- Insert Diet Plan
    INSERT INTO tblDietPlans
    (
        CaloriesPerDay,
        DietPlanDocument,
        ConditionStatus
    )
    VALUES
    (
        @CaloriesPerDay,
        @DietPlanDocument,
        @ConditionStatus
    );

    SELECT 'Diet Plan Inserted Successfully.' AS Message;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName;

END CATCH
END;
GO