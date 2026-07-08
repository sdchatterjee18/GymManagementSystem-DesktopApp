CREATE PROC spInsertDataIntoMembershipPlan
(
    @MembershipPlanName VARCHAR(100),
    @PlanTypeId         INT,
    @DurationInDays     INT,
    @Price              DECIMAL(10,2),
    @Description        VARCHAR(MAX) = NULL,
    @IsActive           BIT = 1
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
       
        IF @MembershipPlanName IS NULL OR LTRIM(RTRIM(@MembershipPlanName)) = ''
        BEGIN
            SELECT 'MembershipPlanName cannot be empty.' AS Message
            RETURN;
        END

        IF @DurationInDays IS NULL OR @DurationInDays <= 0
        BEGIN
            SELECT 'DurationInDays must be greater than zero.' AS Message
            RETURN;
        END

        IF @Price IS NULL OR @Price < 0
        BEGIN
            SELECT 'Price cannot be negative.' AS Message
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblMembershipPlanType WHERE PlanTypeId = @PlanTypeId)
        BEGIN
            SELECT 'Invalid PlanTypeId. No matching record found in tblMembershipPlanType.' AS Message
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM tblMembershipPlans WHERE MembershipPlanName = @MembershipPlanName)
        BEGIN
            SELECT 'A membership plan with this name already exists.' AS Message            
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
            @IsActive
        );

         SELECT 'New record was added successfuly.' AS Message

    END TRY
    BEGIN CATCH
       SELECT ERROR_MESSAGE() AS Message
    END CATCH
END