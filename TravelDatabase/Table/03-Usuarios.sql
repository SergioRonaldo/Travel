CREATE TABLE Travel.Usuarios(
Id INT IDENTITY(1,1) NOT NULL,
NombreUsuario VARCHAR(45) NOT NULL,
Contrasena VARCHAR(100) NOT NULL,
NombreCompleto VARCHAR(100) NOT NULL,
INDEX IX_Usuarios_NombreUsuario UNIQUE (NombreUsuario),
CONSTRAINT PK_Usuarios PRIMARY KEY (Id)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id autoincrementable',
    @level0type = N'SCHEMA',
    @level0name = N'Travel',
    @level1type = N'TABLE',
    @level1name = N'Usuarios',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO