USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_SelectPaisSelected]    Script Date: 27/05/2022 3:09:21 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[sp_SelectPaisSelected]
AS
BEGIN
	SELECT [id_Pais_Selected] FROM [dbo].[PaisSelected] WHERE [Data] = 'Pais'
END
GO

