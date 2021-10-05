CREATE TABLE Travel.Libros(
ISBN INT  NOT NULL,
Editoriales_Id INT NOT NULL,
Titulo VARCHAR(45) NOT NULL,
Sinopsis TEXT NOT NULL,
N_Paginas INT NOT NULL,
CONSTRAINT PK_Libros PRIMARY KEY (ISBN),
CONSTRAINT FK_Libros_Editoriales FOREIGN KEY(Editoriales_Id) REFERENCES Travel.Editoriales (Id)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id autoincrementable',
    @level0type = N'SCHEMA',
    @level0name = N'Travel',
    @level1type = N'TABLE',
    @level1name = N'Libros',
    @level2type = N'COLUMN',
    @level2name = N'ISBN'
GO