CREATE TABLE Municipio (
	ID_Municipio int IDENTITY (1, 1) NOT NULL,
	Descricao_Municipio varchar (100) NULL,
	Sigla_UF char (2) NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL,
	CONSTRAINT PK_Municipio PRIMARY KEY (ID_Municipio),
	CONSTRAINT FK_Unidades_Federacao FOREIGN KEY (Sigla_UF) REFERENCES Unidades_Federacao(Sigla_UF)
)
GO