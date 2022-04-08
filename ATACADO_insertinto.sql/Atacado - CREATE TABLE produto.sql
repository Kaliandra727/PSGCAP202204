CREATE TABLE produto (
	produtoid INT NOT NULL IDENTITY(1,1),
	subcatid INT NOT NULL,
	catid INT NOT NULL,
	descricao VARCHAR(MAX) NOT NULL,
	CONSTRAINT pk_produto PRIMARY KEY (produtoid),
	CONSTRAINT fk_subcategoria_produto FOREIGN KEY (subcatid) REFERENCES subcategoria(subcatid)
)
GO