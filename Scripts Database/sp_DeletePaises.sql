USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_DeletePaises]    Script Date: 27/05/2022 3:06:33 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_DeletePaises]
	@id int
AS
BEGIN
IF EXISTS (SELECT id_pais FROM [dbo].[PAISES] WHERE id_pais = @id)
	BEGIN
		DELETE FROM dbo.PAISES WHERE id_pais = @id
		SELECT 1
	END
	ELSE
	BEGIN
		SELECT 0
	END
	
END
GO

