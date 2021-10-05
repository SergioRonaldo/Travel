CREATE TABLE Travel.Facturas(
Id INT IDENTITY(1,1)  NOT NULL,
Clientes_Id INT NOT NULL,
NumeroFactura VARCHAR(100) NOT NULL,
FechaSalida DATETIME NOT NULL,
TotalFactura DECIMAL(18,2) NOT NULL,
INDEX IX_fac_Factura_NumeroFactura UNIQUE (NumeroFactura),
CONSTRAINT PK_Facturas PRIMARY KEY (Id),
CONSTRAINT FK_Facturas_Clientes FOREIGN KEY(Clientes_Id) REFERENCES Travel.Clientes (Id)
)