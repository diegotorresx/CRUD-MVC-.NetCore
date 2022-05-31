USE [Prueba]
GO

/****** Object:  Table [dbo].[GIROS]    Script Date: 27/05/2022 3:05:25 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GIROS](
	[GIR_GIRO_ID] [int] IDENTITY(1,1) NOT NULL,
	[GIR_RECIBO] [nvarchar](200) NOT NULL,
	[GIR_CIUDAD_ID] [int] NOT NULL
) ON [PRIMARY]
GO

