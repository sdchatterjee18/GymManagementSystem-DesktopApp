CREATE PROC spInsertDataIntoMembershipPlansTable
(
    @MembershipPlanName VARCHAR(100),
    @PlanType VARCHAR(50),
    @DurationInDays INT,
    @Price DECIMAL(10,2),
    @Description VARCHAR(MAX) = NULL
)
AS
BEGIN
    BEGIN TRY
        SET @MembershipPlanName = LTRIM(RTRIM(@MembershipPlanName));
        SET @PlanType = LTRIM(RTRIM(@PlanType));

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

        IF @PlanType IS NULL OR @PlanType = ''
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
        IF @PlanType LIKE '%[^A-Za-z ]%'
        BEGIN
            SELECT 'Plan Type Can Only Contain Letters And Spaces.' AS Message;
            RETURN;
        END
        IF @DurationInDays <= 0
        BEGIN
            SELECT 'Duration Must Be Greater Than 0.' AS Message;
            RETURN;
        END
        IF @DurationInDays > 365
        BEGIN
            SELECT 'Duration Seems Invalid (Too Large).' AS Message;
            RETURN;
        END
        IF @Price < 0
        BEGIN
            SELECT 'Price Cannot Be Negative.' AS Message;
            RETURN;
        END

        IF @Price > 999999.99
        BEGIN
            SELECT 'Price Is Too Large.' AS Message;
            RETURN;
        END
        IF @Description IS NOT NULL AND LEN(@Description) > 1000
        BEGIN
            SELECT 'Description Is Too Long.' AS Message;
            RETURN;
        END
        IF EXISTS
        (
            SELECT 1
            FROM tblMembershipPlans
            WHERE MembershipPlanName = @MembershipPlanName
              AND PlanType = @PlanType
        )
        BEGIN
            SELECT 'Membership Plan Already Exists.' AS Message;
            RETURN;
        END
        INSERT INTO tblMembershipPlans
        (
            MembershipPlanName,
            PlanType,
            DurationInDays,
            Price,
            Description,
            IsActive
        )
        VALUES
        (
            @MembershipPlanName,
            @PlanType,
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