USE [Prueba]
GO

/****** Object:  Table [dbo].[CIUDADES]    Script Date: 27/05/2022 3:04:39 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CIUDADES](
	[id_ciudad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[id_pais] [int] NOT NULL
) ON [PRIMARY]
GO

