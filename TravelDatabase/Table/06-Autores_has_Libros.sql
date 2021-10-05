CREATE TABLE Travel.Autores_has_Libros(
Autores_Id INT NOT NULL,
Libros_ISBN INT NOT NULL,
CONSTRAINT PK_Autores_has_Libros PRIMARY KEY (Autores_Id,Libros_ISBN),
CONSTRAINT FK_Autores FOREIGN KEY(Autores_Id) REFERENCES Travel.Autores (Id),
CONSTRAINT FK_Libros FOREIGN KEY(Libros_ISBN) REFERENCES Travel.Libros (ISBN)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id autoincrementable',
    @level0type = N'SCHEMA',
    @level0name = N'Travel',
    @level1type = N'TABLE',
    @level1name = N'Autores_has_Libros',
    @level2type = N'COLUMN',
    @level2name = N'Autores_Id'
GO