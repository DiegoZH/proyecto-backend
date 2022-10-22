CREATE PROCEDURE [dbo].[Ups_Sel_FiltroProductoxTienda]
(@IdProducto INT,
 @CodigoTienda INT,
 @Mes INT,
 @Anio INT
)
AS
BEGIN

SELECT IdProducto, CodigoTienda, Stock, Demanda, FechaLlegadaAlmacen, FechaSalidaAlmacen, DiasInventario, PrecioRemate, 
CantidadComprada, CantidadVendidaRemate 
FROM [dbo].[ProductoxTienda]
WHERE 
	1= CASE 
	WHEN @IdProducto=0 THEN 1 
    WHEN IdProducto LIKE @IdProducto THEN 1 
    ELSE 0 
    END 
    AND 1 = CASE 
    WHEN @CodigoTienda=0 THEN 1 
    WHEN CodigoTienda LIKE @CodigoTienda THEN 1 
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