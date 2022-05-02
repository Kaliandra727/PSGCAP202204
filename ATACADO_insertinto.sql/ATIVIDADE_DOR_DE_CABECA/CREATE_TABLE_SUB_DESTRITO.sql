CREATE TABLE Sub_Destrito(
	ID_Sub_Destrito int IDENTITY (1, 1) NOT NULL,
	Descricao_Sub_Destrito varchar (100) NULL,
	Sigla_UF char (2) NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Sub_Destrito PRIMARY KEY (ID_Sub_Destrito),
	CONSTRAINT FK_Unidades_Federacao_Sigla FOREIGN KEY (Sigla_UF) REFERENCES Unidades_Federacao(Sigla_UF)
)
GO

