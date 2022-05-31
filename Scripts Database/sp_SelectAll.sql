USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_SelectAll]    Script Date: 27/05/2022 3:07:25 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_SelectAll]
@id_ciudad int
AS
BEGIN
	SELECT * FROM GIROS WHERE  GIR_CIUDAD_ID = @id_ciudad
END
GO

