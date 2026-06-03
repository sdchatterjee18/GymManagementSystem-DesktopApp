CREATE PROC spInsertDataIntoMembershiftTable
(
	@MemberId INT,
	@ShiftId INT,
	@IsActive BIT
)
AS 
BEGIN
	BEGIN TRY
		IF NOT EXISTS
		(
			SELECT 1 
			FROM tblMember 
			WHERE MemberId=@MemberId
		)
		BEGIN
			RAISERROR('Member does not exists',16,1) 
			RETURN
		END
		IF NOT EXISTS
		(
			SELECT 1
			FROM tblShift
			WHERE ShiftId=@ShiftId
		)
		BEGIN
			RAISERROR('Shift does not exists',16,1)
			RETURN
		END
		IF @IsActive IS NULL
		BEGIN
			RAISERROR('IsActive can not be null',16,1)
			RETURN
		END
		IF EXISTS
		(
			SELECT 1
			FROM tblMemberShift
			WHERE MemberId = @MemberId
			and ShiftId = @ShiftId
		)
		BEGIN
			RAISERROR('Member is already assigned in this Shift',16,1)
			RETURN
		END

		INSERT INTO tblMemberShift
		(
			MemberId,
			ShiftId,
			IsActive
		)
		VALUES
		(
			@MemberId,
			@ShiftId,
			@IsActive
		)
		PRINT 'Record is inserted successfully'
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS ERRORMESSAGE;
		SELECT ERROR_NUMBER() AS ERRORNUMBER;
		SELECT ERROR_LINE () AS ERRORLINE;
		SELECT ERROR_PROCEDURE() AS ERRORPROCEDURE;
	END CATCH
END

			

