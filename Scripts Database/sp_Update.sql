USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_Update]    Script Date: 27/05/2022 3:09:33 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_Update]
	@id int,
	@nombre nvarchar(100)
AS
BEGIN
	UPDATE dbo.PAISES
	SET nombre=@nombre
	WHERE id_pais = @id 
END
GO

