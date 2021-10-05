CREATE TABLE Travel.FacturaDetalle(
Id INT IDENTITY(1,1)  NOT NULL,
Facturas_Id INT NOT NULL,
Libros_ISBN INT NOT NULL,
Cantidad DECIMAL(18,2) NOT NULL,
ValorUnitario DECIMAL(18,2) NOT NULL,
TotalFacturaDetalle AS Cantidad * ValorUnitario ,
CONSTRAINT PK_FacturaDetalle PRIMARY KEY (Id),
CONSTRAINT FK_FacturaDetalle_Facturas FOREIGN KEY(Facturas_Id) REFERENCES Travel.Facturas (Id),
CONSTRAINT FK_FacturaDetalle_Libros FOREIGN KEY(Libros_ISBN) REFERENCES Travel.Libros (ISBN),
)