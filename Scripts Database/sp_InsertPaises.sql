USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_InsertPaises]    Script Date: 27/05/2022 3:07:14 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_InsertPaises]
	@nombre varchar(50)
AS
BEGIN
IF NOT EXISTS(SELECT id_pais FROM [dbo].[PAISES] WHERE LOWER(nombre) = LOWER(@nombre))
		BEGIN
			INSERT INTO [dbo].[PAISES] (nombre) VALUES (@nombre)
			SELECT 1
		END
	ELSE
		BEGIN
			SELECT 0
		END
	
END
GO

