SELECT Subcategoria.ID_Subcategoria,
Subcategoria.Descricao_Subcategoria,
Subcategoria.ID_Categoria,
Categoria.Descricao_Categoria
FROM Subcategoria

INNER JOIN Categoria ON Categoria.ID_Categoria = Subcategoria.ID_Categoria;
