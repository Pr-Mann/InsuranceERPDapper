-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Priyank Mangukiya>
-- Create date: <Dec 2, 2023>
-- Description:	<Get all policies>
-- =============================================

IF EXISTS (select * from SYSOBJECTS WHERE ID = OBJECT_ID(N'dbo.GetAllPolicies') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP Procedure GetAllPolicies
GO

CREATE PROCEDURE GetAllPolicies
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT PolicyId, PolicyNumber, Status, Premium, HolderName, Address, Comment
	FROM Policy
	ORDER BY PolicyId DESC
END
GO
