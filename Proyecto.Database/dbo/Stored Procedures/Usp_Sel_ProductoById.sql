CREATE PROCEDURE [dbo].[Usp_Sel_ProductoById] (@IdProducto INT)
AS
BEGIN

SELECT IdProducto, Nombre, Descripcion, PrecioVenta, PrecioCompra FROM [dbo].[Producto]
WHERE IdProducto = @IdProducto

END