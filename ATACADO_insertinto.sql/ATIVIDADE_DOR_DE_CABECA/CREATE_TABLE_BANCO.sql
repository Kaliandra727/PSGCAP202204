CREATE TABLE Banco(
	ID_Banco int IDENTITY (1, 1) NOT NULL,
	Cod_Banco int NULL ,
	Descricao_Banco varchar(MAX),
	Site_Banco varchar(MAX),
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL,
	CONSTRAINT PK_Banco PRIMARY KEY (ID_Banco)
)
GO

