USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_SelectById]    Script Date: 27/05/2022 3:08:05 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_SelectById]
	@id int
AS
BEGIN
	SELECT * FROM dbo.PruebaMonica WHERE id = @id 
END
GO

