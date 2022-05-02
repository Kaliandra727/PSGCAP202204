CREATE TABLE Distrito(
	ID_Distrito int IDENTITY (1, 1) NOT NULL,
	Descricao_Distrito varchar (100),
	Sigla_UF char (2),
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL,
	CONSTRAINT PK_Distrito PRIMARY KEY (ID_Distrito),
	CONSTRAINT FK_Unidade_Distrito FOREIGN KEY (Sigla_UF) REFERENCES Unidades_Federacao(Sigla_UF)
)
GO