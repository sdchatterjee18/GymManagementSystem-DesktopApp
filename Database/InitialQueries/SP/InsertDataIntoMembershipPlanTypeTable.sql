CREATE PROC spInsertDataIntoMembershipPlanTypeTable
(
    @PlanType VARCHAR(50)
)
AS
BEGIN
    BEGIN TRY
        SET @PlanType = LTRIM(RTRIM(@PlanType));
        IF @PlanType IS NULL OR @PlanType = ''
        BEGIN
            SELECT 'Plan Type is Required.' AS Message;
            RETURN;
        END
        IF LEN(@PlanType) < 3 OR LEN(@PlanType) > 50
        BEGIN
            SELECT 'Plan Type Must Be Between 3 And 50 Characters.' AS Message;
            RETURN;
        END
        IF @PlanType LIKE '%[^A-Za-z ]%'
        BEGIN
            SELECT 'Plan Type Can Contain Only Letters And Spaces.' AS Message;
            RETURN;
        END
        IF @PlanType LIKE '%  %'
        BEGIN
            SELECT 'Extra Spaces Are Not Allowed.' AS Message;
            RETURN;
        END
        IF EXISTS
        (
            SELECT 1
            FROM tblMembershipPlanType
            WHERE LOWER(PlanType) = LOWER(@PlanType)
        )
        BEGIN
            SELECT 'Plan Type Already Exists.' AS Message;
            RETURN;
        END
        INSERT INTO tblMembershipPlanType
        (
            PlanType
        )
        VALUES
        (
            @PlanType
        );
        SELECT 'Membership Plan Type Inserted Successfully.' AS Message;
    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;
    END CATCH
END
GO