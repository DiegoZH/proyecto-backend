CREATE PROCEDURE [dbo].[Usp_Sel_Tienda]
AS
BEGIN

SELECT CodigoTienda, Nombre, Direccion, Objetivo FROM [dbo].[Tienda]

END