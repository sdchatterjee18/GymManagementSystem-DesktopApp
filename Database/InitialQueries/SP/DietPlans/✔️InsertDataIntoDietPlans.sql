CREATE PROC spInsertDataIntoDietPlans
(
    @CaloriesPerDay INT,
    @DietPlanDocument VARBINARY(MAX),
    @ConditionStatus VARCHAR(MAX)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @ConditionStatus = LTRIM(RTRIM(ISNULL(@ConditionStatus, '')));

        IF @CaloriesPerDay IS NULL OR @CaloriesPerDay <= 0
        BEGIN
            SELECT 'Calories Per Day must be greater than 0.' AS Message;
            RETURN;
        END;

        IF @ConditionStatus = ''
        BEGIN
            SELECT 'Condition Status is Required.' AS Message;
            RETURN;
        END;

        IF EXISTS
        (
            SELECT 1
            FROM tblDietPlans
            WHERE CaloriesPerDay = @CaloriesPerDay
              AND ConditionStatus = @ConditionStatus
        )
        BEGIN
            SELECT 'Diet Plan Already Exists.' AS Message;
            RETURN;
        END;

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
END
GO