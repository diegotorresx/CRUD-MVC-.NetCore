USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_SelectCiudad]    Script Date: 27/05/2022 3:08:16 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_SelectCiudad]
@id_pais int
AS
BEGIN
	SELECT * FROM CIUDADES WHERE  id_pais = @id_pais
END
GO

