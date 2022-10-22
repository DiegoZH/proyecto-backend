CREATE TABLE [dbo].[ProductoxTienda](
	[IdProducto] [int] NULL,
	[CodigoTienda] [int] NULL,
	[Stock] [int] NULL,
	[Demanda] [int] NULL,
	[FechaLlegadaAlmacen] [datetime] NULL,
	[FechaSalidaAlmacen] [datetime] NULL,
	[DiasInventario] [int] NULL,
	[PrecioRemate] [float] NULL,
	[CantidadComprada] [int] NULL,
	[CantidadVendida] [int] NULL,
	[CantidadVendidaRemate] [int] NULL,
	FOREIGN KEY ([IdProducto]) REFERENCES [dbo].[Producto] ([IdProducto]),
	FOREIGN KEY ([CodigoTienda]) REFERENCES [dbo].[Tienda] ([CodigoTienda])
);