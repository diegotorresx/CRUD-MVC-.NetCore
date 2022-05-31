USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_DeleteGiros]    Script Date: 27/05/2022 3:06:21 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_DeleteGiros]
	@id int
AS
BEGIN
IF EXISTS (SELECT GIR_GIRO_ID FROM dbo.GIROS WHERE GIR_GIRO_ID = @id)
	BEGIN
		DELETE FROM dbo.GIROS WHERE GIR_GIRO_ID = @id
		SELECT 1
	END
	ELSE
	BEGIN
		SELECT 0
	END
	
END
GO

