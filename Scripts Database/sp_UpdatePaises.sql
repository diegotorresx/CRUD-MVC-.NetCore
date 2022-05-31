USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_UpdatePaises]    Script Date: 27/05/2022 3:10:07 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_UpdatePaises]
	@id int,
	@nombre nvarchar(100)
AS
BEGIN
	IF EXISTS (SELECT id_pais FROM [dbo].[PAISES] WHERE id_pais = @id)
	BEGIN
		UPDATE dbo.PAISES
		SET nombre=@nombre
		WHERE id_pais = @id
		SELECT 1
	END
	ELSE
	BEGIN
		SELECT 0
	END
END
GO

