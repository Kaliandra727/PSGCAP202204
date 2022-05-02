CREATE TABLE Cursos(
	ID_Cursos int IDENTITY (1, 1) NOT NULL,
	Descricao_Cursos varchar(MAX),
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL,
	CONSTRAINT PK_Cursos PRIMARY KEY (ID_Cursos)
)
GO

