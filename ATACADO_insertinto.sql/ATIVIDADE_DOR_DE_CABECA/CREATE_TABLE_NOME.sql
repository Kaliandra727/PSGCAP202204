CREATE TABLE Nome(
	ID_Nome int IDENTITY (1, 1) NOT NULL,
	Nome varchar (50) NULL ,
	Sexo char (1) NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Nome PRIMARY KEY (ID_Nome)
)
GO