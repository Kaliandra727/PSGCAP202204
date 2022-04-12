SELECT Categoria.ID_Categoria,
Categoria.Descricao_Categoria,
Subcategoria.ID_Subcategoria,
Subcategoria.Descricao_subcategoria
FROM Subcategoria 
INNER JOIN Categoria ON Categoria.ID_Categoria= Subcategoria.ID_Subcategoria
WHERE (Subcategoria.ID_Categoria = 5);
