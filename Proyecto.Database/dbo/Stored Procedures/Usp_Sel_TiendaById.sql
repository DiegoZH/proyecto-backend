CREATE PROCEDURE [dbo].[Usp_Sel_TiendaById] (@CodigoTienda INT)
AS
BEGIN

SELECT CodigoTienda, Nombre, Direccion, Objetivo FROM [dbo].[Tienda]
WHERE CodigoTienda = @CodigoTienda

END