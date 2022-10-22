CREATE PROCEDURE [dbo].[Usp_Sel_ProductoxTienda]
AS
BEGIN

SELECT IdProducto,CodigoTienda,FechaLlegadaAlmacen,FechaSalidaAlmacen,DiasInventario,Demanda,CantidadComprada,CantidadVendida,CantidadVendidaRemate,Stock
FROM [dbo].[ProductoxTienda]

END