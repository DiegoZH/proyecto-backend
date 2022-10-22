CREATE PROCEDURE [dbo].[Usp_Sel_Producto]
AS
BEGIN

SELECT IdProducto, Nombre, Descripcion, PrecioVenta, PrecioCompra from [dbo].[Producto]

END