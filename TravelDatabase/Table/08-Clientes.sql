CREATE TABLE Travel.Clientes(
Id INT IDENTITY(1,1)  NOT NULL,
TipoDocumentos_Id INT NOT NULL,
NumeroDocumento VARCHAR(50) NOT NULL,
Nombres VARCHAR(100) NOT NULL,
Apellidos VARCHAR(100) NOT NULL,
INDEX IX_cli_Cliente_tdo_Numero UNIQUE (TipoDocumentos_Id,NumeroDocumento),
CONSTRAINT PK_Clientes PRIMARY KEY (Id),
CONSTRAINT FK_cli_Cliente_TipoDocumento FOREIGN KEY(TipoDocumentos_Id) REFERENCES Travel.TipoDocumentos (Id)
)

GO