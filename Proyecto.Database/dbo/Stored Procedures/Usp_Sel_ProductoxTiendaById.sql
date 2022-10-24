CREATE PROCEDURE [dbo].[Usp_Sel_ProductoxTiendaById] (@IdRegistro INT)
AS
BEGIN

SELECT IdRegistro,P.Nombre AS NombrePreoducto, T.Nombre AS NombreTienda,Stock,Demanda,FechaLlegadaAlmacen,FechaSalidaAlmacen,DiasInventario,PrecioRemate,CantidadComprada,CantidadVendida,CantidadVendidaRemate FROM [dbo].[ProductoxTienda] AS PT
JOIN [dbo].[Producto] AS P
ON PT.IdProducto = P.IdProducto
JOIN [dbo].[Tienda] AS T
ON PT.CodigoTienda = T.CodigoTienda
WHERE IdRegistro = @IdRegistro

END