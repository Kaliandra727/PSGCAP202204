CREATE TABLE Idioma (
	ID_Idioma int IDENTITY (1, 1) NOT NULL,
	Abreviacao_Idioma char (2),
	Descricao_Idioma varchar (50),
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL,
	CONSTRAINT PK_Idioma PRIMARY KEY (ID_Idioma)
)
GO

