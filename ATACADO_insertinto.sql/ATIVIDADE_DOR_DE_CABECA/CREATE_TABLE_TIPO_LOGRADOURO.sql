CREATE TABLE Tipo_Logradouro(
	ID_Tipo_Logradouro int IDENTITY (1, 1) NOT NULL,
	Tipo_Logradouro varchar (50) NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL,
	CONSTRAINT PK_Tipo_Logradouro PRIMARY KEY (ID_Tipo_Logradouro)
)
GO