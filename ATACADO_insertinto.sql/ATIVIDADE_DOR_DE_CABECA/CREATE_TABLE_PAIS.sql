CREATE TABLE Pais(
	ID_Pais int IDENTITY (1, 1) NOT NULL,
	Sigla_Pais char (3) NULL ,
	Cod_Idioma char (2) NULL ,
	Descricao_Pais varchar (MAX) NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Pais PRIMARY KEY (ID_Pais)
)
GO