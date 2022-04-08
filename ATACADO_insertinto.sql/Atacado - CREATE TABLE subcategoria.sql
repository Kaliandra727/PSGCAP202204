CREATE TABLE subcategoria (
	subcatid INT NOT NULL IDENTITY(1,1),
	catid INT NOT NULL,
	descricao VARCHAR(MAX) NOT NULL,
	datainsert DATETIME NOT NULL DEFAULT GETDATE(),
	CONSTRAINT pk_subcategoria PRIMARY KEY (subcatid),
	CONSTRAINT fk_subcategoria_categoria FOREIGN KEY (catid) REFERENCES categoria(catid)
)
GO
