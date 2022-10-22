CREATE PROCEDURE [dbo].[Usp_Upd_Producto]
(@IdProducto INT,
 @Nombre VARCHAR(100),
 @Descripcion VARCHAR(300),
 @PrecioVenta FLOAT,
 @PrecioCompra FLOAT)
AS
BEGIN

UPDATE [dbo].[Producto] SET 
	Nombre = @Nombre,
	Descripcion = @Descripcion,
	PrecioVenta = @PrecioVenta,
	PrecioCompra = @PrecioCompra
WHERE IdProducto = @IdProducto

END