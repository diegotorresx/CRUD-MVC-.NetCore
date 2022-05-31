USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_SelectAllGiros]    Script Date: 27/05/2022 3:07:54 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_SelectAllGiros]
AS
BEGIN
	SELECT * FROM GIROS
END
GO

