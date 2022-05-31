USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_SelectOneCity]    Script Date: 27/05/2022 3:08:36 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_SelectOneCity]
@id int
AS
BEGIN
	SELECT * FROM CIUDADES WHERE id_ciudad = @id
END
GO

