USE [InsuranceERP]
GO
/****** Object:  StoredProcedure [dbo].[GetPolicy]    Script Date: 12/2/2023 6:08:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetPolicy](
	@PolicyId [uniqueidentifier]
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Policy 
	WHERE PolicyId = @PolicyId
END
