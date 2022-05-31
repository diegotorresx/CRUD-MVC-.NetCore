USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_DeleteCiudades]    Script Date: 27/05/2022 3:06:08 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_DeleteCiudades]
	@id int
AS
BEGIN
IF EXISTS (SELECT id_ciudad FROM [dbo].[CIUDADES] WHERE id_ciudad = @id)
	BEGIN
		DELETE FROM dbo.CIUDADES WHERE id_ciudad = @id
		SELECT 1
	END
	ELSE
	BEGIN
		SELECT 0
	END
END
GO

