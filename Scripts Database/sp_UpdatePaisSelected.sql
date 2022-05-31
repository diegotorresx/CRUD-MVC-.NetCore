USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_UpdatePaisSelected]    Script Date: 27/05/2022 3:10:18 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[sp_UpdatePaisSelected]
@id_pais nvarchar(50)
AS
BEGIN
	UPDATE [dbo].[PaisSelected]
	SET [id_Pais_Selected] = @id_pais
	WHERE [Data] = 'Pais'
END
GO

