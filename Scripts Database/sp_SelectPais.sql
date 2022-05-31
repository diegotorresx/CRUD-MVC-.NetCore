USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_SelectPais]    Script Date: 27/05/2022 3:08:59 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_SelectPais]
@id int
AS
BEGIN
	SELECT * FROM PAISES WHERE id_pais = @id
END
GO

