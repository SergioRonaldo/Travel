CREATE TABLE Travel.Editoriales(
Id INT IDENTITY(1,1) NOT NULL,
Nombre VARCHAR(45) NOT NULL,
Sede VARCHAR(45) NOT NULL,
INDEX IX_Editoriales_Nombre_Sede UNIQUE (Nombre,Sede),
CONSTRAINT PK_Editoriales PRIMARY KEY (Id)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id autoincrementable',
    @level0type = N'SCHEMA',
    @level0name = N'Travel',
    @level1type = N'TABLE',
    @level1name = N'Editoriales',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO