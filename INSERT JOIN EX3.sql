SELECT Categoria.ID_Categoria,
Categoria.Descricao_Categoria,
Subcategoria.ID_Subcategoria,
Subcategoria.Descricao_Subcategoria,
Subcategoria.Situacao
FROM Subcategoria
INNER JOIN Categoria ON Categoria.ID_Categoria = Subcategoria.ID_Categoria
WHERE (Subcategoria.ID_Categoria = 3 OR Subcategoria.ID_Categoria = 5 OR Subcategoria.ID_Categoria = 7 OR Subcategoria.ID_Categoria = 9)
