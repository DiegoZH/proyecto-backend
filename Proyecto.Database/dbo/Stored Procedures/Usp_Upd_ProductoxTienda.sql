CREATE PROCEDURE [dbo].[Ups_Upd_ProductoxTienda]
(@IdRegistro INT,
 @IdProducto INT,
 @CodigoTienda INT,
 @Stock INT,
 @Demanda INT,
 @FechaLlegadaAlmacen DATETIME,
 @FechaSalidaAlmacen DATETIME,
 @DiasInventario INT,
 @PrecioRemate FLOAT,
 @CantidadComprada INT,
 @CantidadVendida INT,
 @CantidadVendidaRemate INT)
AS
BEGIN

UPDATE [dbo].[ProductoxTienda] SET 
	IdProducto = @IdProducto,
	CodigoTienda = @CodigoTienda,
	Stock = @Stock,
	Demanda = @Demanda,
	FechaLlegadaAlmacen = @FechaLlegadaAlmacen,
	FechaSalidaAlmacen = @FechaSalidaAlmacen,
	DiasInventario = @DiasInventario,
	PrecioRemate = @PrecioRemate,
	CantidadComprada = @CantidadComprada,
	CantidadVendida = @CantidadVendida,
	CantidadVendidaRemate = @CantidadVendidaRemate
WHERE IdRegistro = @IdRegistro

END