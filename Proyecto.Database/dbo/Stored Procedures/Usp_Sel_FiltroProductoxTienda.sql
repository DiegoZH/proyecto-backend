CREATE PROCEDURE [dbo].[Ups_Sel_FiltroProductoxTienda]
(@IdProducto INT,
 @CodigoTienda INT,
 @Mes INT,
 @Anio INT
)
AS
BEGIN

SELECT P.Nombre AS NombreProducto, T.Nombre AS NombreTienda, Stock, Demanda, FechaLlegadaAlmacen, FechaSalidaAlmacen, DiasInventario, PrecioRemate, 
CantidadVendida, CantidadComprada, CantidadVendidaRemate 
FROM [dbo].[ProductoxTienda] AS PT
JOIN [dbo].[Producto] AS P
ON P.IdProducto = PT.IdProducto
JOIN [dbo].[Tienda] AS T
ON T.CodigoTienda = PT.CodigoTienda
WHERE 
	1= CASE 
	WHEN @NombreProducto='' THEN 1 
    WHEN P.Nombre LIKE upper(@NombreProducto)+'%' THEN 1 
    ELSE 0 
    END 
    AND 1 = CASE 
    WHEN @NombreTienda='' THEN 1 
    WHEN T.Nombre LIKE upper(@NombreTienda)+'%' THEN 1 
    ELSE 0 
    END
	AND 1 = CASE 
    WHEN @Mes = 0 THEN 1 
    WHEN MONTH(FechaLlegadaAlmacen) = @Mes THEN 1 
    ELSE 0 
    END
	AND 1 = CASE 
	WHEN @Anio = 0 THEN 1 
    WHEN YEAR(FechaLlegadaAlmacen) = @Anio THEN 1 
    ELSE 0 
    END

END