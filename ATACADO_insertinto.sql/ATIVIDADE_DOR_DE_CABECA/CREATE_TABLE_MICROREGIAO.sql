CREATE TABLE Microregiao(
	ID_MicroRegiao int IDENTITY (1, 1) NOT NULL,
	Descricao_Microregiao varchar (100),
	Sigla_UF char (2),
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Microregiao PRIMARY KEY (ID_MicroRegiao)
	CONSTRAINT FK_Unidades_Microregiao FOREIGN KEY (Sigla_UF) REFERENCES Unidades_Federacao(Sigla_UF)
)
GO