USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_UpdateCiudades]    Script Date: 27/05/2022 3:09:44 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_UpdateCiudades]
	@id_ciudad int,
	@nombre nvarchar(100),
	@id_pais int
AS
BEGIN
	IF EXISTS (SELECT id_ciudad FROM [dbo].[CIUDADES] WHERE id_ciudad = @id_ciudad)
	BEGIN
		UPDATE dbo.CIUDADES
		SET nombre=@nombre, id_pais = @id_pais
		WHERE id_ciudad = @id_ciudad 
		SELECT 1
	END
	ELSE
	BEGIN
		SELECT 0
	END
END
GO

