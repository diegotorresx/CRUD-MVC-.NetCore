USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_InsertCIUDADES]    Script Date: 27/05/2022 3:06:48 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_InsertCIUDADES]
	@nombre varchar(50),
	@id_pais int
AS
BEGIN
	IF NOT EXISTS(SELECT id_ciudad FROM [dbo].[CIUDADES] WHERE LOWER(nombre) = LOWER(@nombre))
		BEGIN
			INSERT INTO [dbo].[CIUDADES] (nombre,id_pais) VALUES (@nombre,@id_pais)
			SELECT 1
		END
	ELSE
		BEGIN
			SELECT 0
		END
END
GO

