USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_SelectPaises]    Script Date: 27/05/2022 3:09:11 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_SelectPaises]
AS
BEGIN
	SELECT * FROM PAISES
END
GO

