SELECT Produto.ID_Categoria,
Categoria.Descricao_Categoria,
Produto.ID_Subcategoria,
Subcategoria.Descricao_Subcategoria,
Produto.ID_Produto,
Produto.Descricao_Produto
FROM Produto
INNER JOIN Subcategoria ON Subcategoria.ID_Subcategoria = Produto.ID_Subcategoria
INNER JOIN Categoria ON Categoria.ID_Categoria = Subcategoria.ID_Categoria
GO
