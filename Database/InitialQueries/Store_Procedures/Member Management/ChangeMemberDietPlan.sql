CREATE PROC spChangeMemberDietPlan
(
    @MemberId INT,
    @DietPlanId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE
        @CurrentDietPlanId INT,
        @AssignDate DATE;

    BEGIN TRY
        BEGIN TRANSACTION;

        ------------------------------------------------
        -- Member Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT
                0 AS Success,
                'Member does not exist or is inactive.' AS Message;

            ROLLBACK TRANSACTION;
            RETURN;
        END

        ------------------------------------------------
        -- Diet Plan Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblDietPlans
            WHERE DietPlanId = @DietPlanId
        )
        BEGIN
            SELECT
                0 AS Success,
                'Invalid Diet Plan.' AS Message;

            ROLLBACK TRANSACTION;
            RETURN;
        END

        ------------------------------------------------
        -- Current Active Diet Plan
        ------------------------------------------------
        SELECT TOP 1
            @CurrentDietPlanId = DietPlanId,
            @AssignDate = AssignDate
        FROM tblMemberDietAssignment
        WHERE MemberId = @MemberId
          AND IsActive = 1
        ORDER BY AssignDate DESC;

        ------------------------------------------------
        -- Active Diet Plan Exists
        ------------------------------------------------
        IF @CurrentDietPlanId IS NULL
        BEGIN
            SELECT
                0 AS Success,
                'No active diet plan found for this member.' AS Message;

            ROLLBACK TRANSACTION;
            RETURN;
        END

        ------------------------------------------------
        -- Same Diet Plan
        ------------------------------------------------
        IF @CurrentDietPlanId = @DietPlanId
        BEGIN
            SELECT
                0 AS Success,
                'Member is already assigned to this Diet Plan.' AS Message;

            ROLLBACK TRANSACTION;
            RETURN;
        END

        ------------------------------------------------
        -- Same Month Restriction
        ------------------------------------------------
        IF YEAR(@AssignDate) = YEAR(GETDATE())
           AND MONTH(@AssignDate) = MONTH(GETDATE())
        BEGIN
            SELECT
                0 AS Success,
                'Diet Plan can be changed only from next month.' AS Message;

            ROLLBACK TRANSACTION;
            RETURN;
        END

        ------------------------------------------------
        -- Deactivate Previous Diet Plan
        ------------------------------------------------
        UPDATE tblMemberDietAssignment
        SET IsActive = 0
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        ------------------------------------------------
        -- Assign New Diet Plan
        ------------------------------------------------
        INSERT INTO tblMemberDietAssignment
        (
            MemberId,
            DietPlanId,
            AssignDate,
            IsActive
        )
        VALUES
        (
            @MemberId,
            @DietPlanId,
            CAST(GETDATE() AS DATE),
            1
        );

        COMMIT TRANSACTION;

        SELECT
            1 AS Success,
            'Diet Plan changed successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT
            0 AS Success,
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO