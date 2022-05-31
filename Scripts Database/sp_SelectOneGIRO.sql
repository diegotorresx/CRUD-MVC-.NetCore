USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_SelectOneGIRO]    Script Date: 27/05/2022 3:08:47 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_SelectOneGIRO]
@id int
AS
BEGIN
	SELECT * FROM GIROS WHERE GIR_GIRO_ID = @id
END
GO

