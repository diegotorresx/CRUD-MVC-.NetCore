USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[sp_InsertGiros]    Script Date: 27/05/2022 3:07:01 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_InsertGiros]
	@giro_recibido varchar(100),
	@giro_Ciudad_id int
AS
BEGIN
	IF NOT EXISTS(SELECT GIR_GIRO_ID FROM GIROS WHERE GIR_RECIBO = @giro_recibido AND GIR_CIUDAD_ID = @giro_Ciudad_id)
	BEGIN
		INSERT INTO [dbo].[GIROS] (GIR_RECIBO,GIR_CIUDAD_ID) VALUES (@giro_recibido,@giro_Ciudad_id)
		SELECT 1
	END
	ELSE
	BEGIN
		SELECT 0
	END
END
GO

