CREATE TABLE Mesoregiao(
	ID_Mesoregiao int IDENTITY (1, 1) NOT NULL,
	Descricao_Mesoregiao varchar (100),
	Sigla_UF char (2),
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL,
	CONSTRAINT PK_Mesoregiao PRIMARY KEY (ID_Mesoregiao),
	CONSTRAINT FK_Unidade_Mesoregiao FOREIGN KEY (Sigla_UF) REFERENCES Unidades_Federacao(Sigla_UF)
)
GO