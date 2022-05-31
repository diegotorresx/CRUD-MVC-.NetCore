USE [Prueba]
GO

/****** Object:  Table [dbo].[PAISES]    Script Date: 27/05/2022 3:05:06 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PAISES](
	[id_pais] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL
) ON [PRIMARY]
GO

