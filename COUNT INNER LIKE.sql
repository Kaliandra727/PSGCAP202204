SELECT CAT.Descricao_Categoria AS 'Nome Categoria',
SUB.Descricao_Subcategoria AS 'Nome Subcategoria',
PROD.Descricao_Produto AS 'Nome Produto'
FROM Produto AS PROD
INNER JOIN Subcategoria AS SUB ON SUB.ID_Subcategoria = PROD.ID_Subcategoria
INNER JOIN Categoria AS CAT ON CAT.ID_Categoria =PROD.ID_Categoria
WHERE (Descricao_Categoria LIKE '%Bebidas%') AND (Descricao_Subcategoria LIKE 'Refresco%') AND (Descricao_Produto LIKE '%TANG%')
GO


SELECT COUNT(*) AS 'Quantidade de Itens' FROM Produto AS PROD
INNER JOIN Subcategoria AS SUB ON SUB.ID_Subcategoria = PROD.ID_Subcategoria
INNER JOIN Categoria AS CAT ON CAT.ID_Categoria =PROD.ID_Categoria
WHERE (Descricao_Categoria LIKE '%Bebidas%') AND (Descricao_Subcategoria LIKE 'Refresco%') AND (Descricao_Produto LIKE '%TANG%')
GO
