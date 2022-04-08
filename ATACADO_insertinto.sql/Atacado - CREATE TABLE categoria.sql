CREATE TABLE categoria (
	catid INT NOT NULL IDENTITY(1,1),
	descricao VARCHAR(MAX) NOT NULL,
	datainsert DATETIME NOT NULL DEFAULT GETDATE(),
	CONSTRAINT pk_categoria PRIMARY KEY (catid)
)
GO

