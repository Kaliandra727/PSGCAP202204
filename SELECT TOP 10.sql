SELECT TOP 10 Descricao_Categoria,Descricao_Subcategoria,Descricao_Produto FROM Produto AS PROD
INNER JOIN Subcategoria AS SUB ON SUB.ID_Subcategoria = PROD.ID_Subcategoria
INNER JOIN Categoria AS CAT ON CAT.ID_Categoria =PROD.ID_Categoria
WHERE (Prod.ID_Categoria = 4) AND (Descricao_Produto LIKE '%Adria%') 
GO

SELECT COUNT(*) AS 'Quantidade de Itens' FROM Produto AS PROD
INNER JOIN Subcategoria AS SUB ON SUB.ID_Subcategoria = PROD.ID_Subcategoria
INNER JOIN Categoria AS CAT ON CAT.ID_Categoria =PROD.ID_Categoria
WHERE (Prod.ID_Categoria = 4) AND (Descricao_Produto LIKE '%Adria%') 
GO
