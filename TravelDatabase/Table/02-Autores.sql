CREATE TABLE Travel.Autores(
Id INT IDENTITY(1,1) NOT NULL,
Nombre VARCHAR(45) NOT NULL,
Apellidos VARCHAR(45) NOT NULL,
CONSTRAINT PK_Autores PRIMARY KEY (Id)
)
GO

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id autoincrementable',
    @level0type = N'SCHEMA',
    @level0name = N'Travel',
    @level1type = N'TABLE',
    @level1name = N'Autores',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
