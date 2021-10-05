CREATE TABLE Travel.TipoDocumentos(
Id INT NOT NULL,
Nombre VARCHAR(50) NOT NULL,
Descripcion VARCHAR(50) NULL,
INDEX IX_TipoDocumento_Nombre UNIQUE (Nombre),
CONSTRAINT PK_TipoDocumento PRIMARY KEY (Id)
)
