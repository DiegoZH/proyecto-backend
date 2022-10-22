CREATE TABLE [dbo].[Tienda](
	[CodigoTienda] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Direccion] [varchar](200) NULL,
	[Objetivo] [float] NULL,
PRIMARY KEY CLUSTERED ([CodigoTienda] ASC)
WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO