USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_SelectAllCiudades]    Script Date: 27/05/2022 3:07:36 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_SelectAllCiudades]
AS
BEGIN
	SELECT * FROM CIUDADES
END
GO

