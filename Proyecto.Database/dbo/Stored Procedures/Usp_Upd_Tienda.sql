CREATE PROCEDURE [dbo].[Ups_Upd_Tienda]
(@CodigoTienda INT,
 @Nombre VARCHAR(100),
 @Direccion VARCHAR(200),
 @Objetivo FLOAT)
AS
BEGIN

UPDATE [dbo].[Tienda] SET 
	Nombre = @Nombre,
	Direccion = @Direccion,
	Objetivo = @Objetivo
WHERE CodigoTienda = @CodigoTienda

END