CREATE TABLE Travel.Inventario(
Id INT IDENTITY(1,1)  NOT NULL,
Libros_ISBN INT NOT NULL,
CantidadIngresada DECIMAL(18,2) NOT NULL,
CantidadSalida DECIMAL(18,2) NOT NULL,
CantidadDisponible AS CantidadIngresada - CantidadSalida ,
INDEX IX_Inventario_Libros_ISBN UNIQUE (Libros_ISBN),
CONSTRAINT PK_Inventario PRIMARY KEY (Id),
CONSTRAINT FK_Inventario_Libros FOREIGN KEY(Libros_ISBN) REFERENCES Travel.Libros (ISBN)
)

GO