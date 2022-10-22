CREATE PROCEDURE [dbo].[Usp_Ins_Producto]
(@Nombre VARCHAR(100),
 @Descripcion VARCHAR(300),
 @PrecioVenta FLOAT,
 @PrecioCompra FLOAT)
AS
BEGIN

INSERT INTO dbo.Producto (Nombre, Descripcion, PrecioVenta, PrecioCompra) VALUES
(@Nombre,@Descripcion,@PrecioVenta,@PrecioCompra)

END