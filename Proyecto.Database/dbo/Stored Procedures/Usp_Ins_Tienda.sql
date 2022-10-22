CREATE PROCEDURE [dbo].[Usp_Ins_Tienda]
(@Nombre VARCHAR(100),
 @Direccion VARCHAR(200),
 @Objetivo FLOAT)
AS
BEGIN

INSERT INTO dbo.Tienda (Nombre, Direccion, Objetivo) VALUES
(@Nombre,@Direccion,@Objetivo)

END