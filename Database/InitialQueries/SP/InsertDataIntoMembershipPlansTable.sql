CREATE PROC spInsertDataIntoMembershipPlansTable
(
    @MembershipPlanName VARCHAR(100),
    @PlanTypeId INT,
    @DurationInDays INT,
    @Price DECIMAL(10,2),
    @Description VARCHAR(MAX) = NULL
)
AS
BEGIN
    BEGIN TRY
        SET @MembershipPlanName = LTRIM(RTRIM(@MembershipPlanName));
        IF @Description IS NOT NULL
        BEGIN
            SET @Description = LTRIM(RTRIM(@Description));
            IF @Description = '' SET @Description = NULL;
        END
        IF @MembershipPlanName IS NULL OR @MembershipPlanName = ''
        BEGIN
            SELECT 'Membership Plan Name is Required.' AS Message;
            RETURN;
        END
        IF @PlanTypeId IS NULL
        BEGIN
            SELECT 'Plan Type is Required.' AS Message;
            RETURN;
        END
        IF @DurationInDays IS NULL
        BEGIN
            SELECT 'Duration In Days is Required.' AS Message;
            RETURN;
        END
        IF @Price IS NULL
        BEGIN
            SELECT 'Price is Required.' AS Message;
            RETURN;
        END
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMembershipPlanType
            WHERE PlanTypeId = @PlanTypeId
        )
        BEGIN
            SELECT 'Invalid PlanTypeId (Not Found In Plan Type Table).' AS Message;
            RETURN;
        END
        IF LEN(@MembershipPlanName) < 3 OR LEN(@MembershipPlanName) > 100
        BEGIN
            SELECT 'Membership Plan Name Must Be Between 3 And 100 Characters.' AS Message;
            RETURN;
        END

        IF @MembershipPlanName LIKE '%[^A-Za-z0-9 ]%'
        BEGIN
            SELECT 'Membership Plan Name Can Only Contain Letters, Numbers And Spaces.' AS Message;
            RETURN;
        END
        IF @DurationInDays <= 0 OR @DurationInDays > 365
        BEGIN
            SELECT 'Invalid Duration.' AS Message;
            RETURN;
        END
        IF @Price < 0 OR @Price > 999999.99
        BEGIN
            SELECT 'Invalid Price.' AS Message;
            RETURN;
        END
        IF @Description IS NOT NULL AND LEN(@Description) > 1000
        BEGIN
            SELECT 'Description Too Long.' AS Message;
            RETURN;
        END
        IF EXISTS
        (
            SELECT 1
            FROM tblMembershipPlans
            WHERE MembershipPlanName = @MembershipPlanName
              AND PlanTypeId = @PlanTypeId
        )
        BEGIN
            SELECT 'Membership Plan Already Exists.' AS Message;
            RETURN;
        END
        INSERT INTO tblMembershipPlans
        (
            MembershipPlanName,
            PlanTypeId,
            DurationInDays,
            Price,
            Description,
            IsActive
        )
        VALUES
        (
            @MembershipPlanName,
            @PlanTypeId,
            @DurationInDays,
            @Price,
            @Description,
            1
        );

        SELECT 'Membership Plan Inserted Successfully.' AS Message;
    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;
    END CATCH
END
GO