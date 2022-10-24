CREATE PROCEDURE [dbo].[Usp_Ins_ProductoxTienda]
(@IdProducto INT,
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

INSERT INTO ProductoxTienda (IdProducto,CodigoTienda,Stock,Demanda,FechaLlegadaAlmacen,FechaSalidaAlmacen,DiasInventario,PrecioRemate,CantidadComprada,CantidadVendida,CantidadVendidaRemate) 
VALUES (@IdProducto,@CodigoTienda,@Stock,@Demanda,@FechaLlegadaAlmacen,@FechaSalidaAlmacen,@DiasInventario,@PrecioRemate,@CantidadComprada,@CantidadVendida,@CantidadVendidaRemate)

END