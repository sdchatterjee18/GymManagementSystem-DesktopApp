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
    SET @MembershipPlanName = LTRIM(RTRIM(@MembershipPlanName))
    SET @PlanType = LTRIM(RTRIM(@PlanType))
    IF @Description IS NOT NULL
        SET @Description = LTRIM(RTRIM(@Description))
    IF @Description = ''
        SET @Description = NULL
    IF @MembershipPlanName IS NULL OR @MembershipPlanName = ''
    BEGIN
        SELECT 'Membership Plan Name is Required.' AS Message
        RETURN
    END
    IF @PlanType IS NULL OR @PlanType = ''
    BEGIN
        SELECT 'Plan Type is Required.' AS Message
        RETURN
    END
    IF @DurationInDays IS NULL
    BEGIN
        SELECT 'Duration In Days is Required.' AS Message
        RETURN
    END
    IF @DurationInDays <= 0
    BEGIN
        SELECT 'Duration In Days Must Be Greater Than 0.' AS Message
        RETURN
    END
    IF @Price IS NULL
    BEGIN
        SELECT 'Price is Required.' AS Message
        RETURN
    END
    IF @Price < 0
    BEGIN
        SELECT 'Price Cannot Be Negative.' AS Message
        RETURN
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblMembershipPlans
        WHERE MembershipPlanName = @MembershipPlanName
          AND PlanType = @PlanType
    )
    BEGIN
        SELECT 'Membership Plan Already Exists.' AS Message
        RETURN
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
        0
    )
    SELECT 'Membership Plan Inserted Successfully.' AS Message
END TRY
BEGIN CATCH
    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName
END CATCH
END
GO