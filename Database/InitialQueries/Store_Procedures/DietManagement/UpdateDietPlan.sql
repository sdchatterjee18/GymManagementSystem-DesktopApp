CREATE PROC spUpdateDietPlan
(
    @DietPlanId INT,
    @CaloriesPerDay INT,
    @DietPlanDocument VARBINARY(MAX) = NULL,
    @ConditionStatus VARCHAR(MAX)
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;

    SET @ConditionStatus = LTRIM(RTRIM(@ConditionStatus));

    ----------------------------
    -- DietPlanId validation
    ----------------------------
    IF @DietPlanId IS NULL
    BEGIN
        SELECT 'Diet Plan Id is Required.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblDietPlans
        WHERE DietPlanId = @DietPlanId
    )
    BEGIN
        SELECT 'Invalid Diet Plan Id.' AS Message;
        RETURN;
    END

    ----------------------------
    -- Calories validation
    ----------------------------
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

    ----------------------------
    -- Condition Status validation
    ----------------------------
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

    ----------------------------
    -- Update Diet Plan
    ----------------------------
    UPDATE tblDietPlans
    SET
        CaloriesPerDay = @CaloriesPerDay,
        ConditionStatus = @ConditionStatus,
        DietPlanDocument = @DietPlanDocument
    WHERE DietPlanId = @DietPlanId;

    SELECT 'Diet Plan Updated Successfully.' AS Message;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message;

END CATCH
END;
GO