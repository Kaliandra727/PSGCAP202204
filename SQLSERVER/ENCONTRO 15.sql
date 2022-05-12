ESTRUTURA CURSOR	

DECLARE @CHAVE INT

DECLARE DB_CURSOR CURSOR FOR
	SELECT ID FROM @TABELA
OPEN DB_CURSOR FETCH NEXT FROM DB_CURSOR INTO @CHAVE

WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT 'VALOR DA CHAVE =' + CONVERT (VARCHAR, @CHAVE)
		FETCH NEXT FROM DB_CURSOR INTO @CHAVE
END

CLOSE DB_CURSOR
DEALLOCATE DB_CURSOR

_______________________________________________________________

CRIANDO STORED PROCEDURE QUE SELECIONA LINHAS DE UMA EM UMA E MUDA A SITUAÇÃO DE ATIVO PARA INATIVO OU VICE E VERSA

CREATE PROCEDURE SP_INATIVAR_fUNCIONARIO_ALEATORIAMENTE
@CONTADORFINAL INT
AS
BEGIN 
DECLARE @TOTALREGISTROS INT
DECLARE @CHAVEINICIAL INT
DECLARE @CHAVESELECIONADA INT
DECLARE @QTDE INT

DECLARE @CONTADORINICIAL INT
--DECLARE @CONTADORFINAL INT

DECLARE @TABELACHAVE TABLE(CHAVE INT NOT NULL PRIMARY KEY)
DECLARE @VERIFICACHAVE INT

SET @CONTADORINICIAL = 0
--SET @CONTADORFINAL = 100

WHILE (@CONTADORINICIAL <> @CONTADORFINAL)
BEGIN
	SET @QTDE = 0
	SET @VERIFICACHAVE = 0
WHILE(@QTDE = 0 AND @VERIFICACHAVE = 0)
BEGIN
	SET @TOTALREGISTROS = (SELECT COUNT(*) FROM Funcionario_Temp)
	SET @CHAVEINICIAL = (SELECT MIN(ID_Funcionario_Temp) FROM Funcionario_Temp)
	SET @CHAVESELECIONADA = (SELECT FLOOR(RAND()*(@TOTALREGISTROS-@CHAVEINICIAL)+@CHAVEINICIAL))
	SET @QTDE = (SELECT COUNT(*) FROM Funcionario_Temp WHERE ID_Funcionario_Temp = (@CHAVESELECIONADA) AND (Situacao = 1))
	SET @VERIFICACHAVE = (SELECT COUNT(*) FROM @TABELACHAVE WHERE CHAVE = @CHAVESELECIONADA)
END
	SET @VERIFICACHAVE =  (SELECT COUNT(*) FROM @TABELACHAVE WHERE CHAVE = @CHAVESELECIONADA)
	IF (@VERIFICACHAVE = 0) 

	BEGIN
		INSERT INTO @TABELACHAVE(CHAVE) VALUES (@CHAVESELECIONADA)
		SET @CONTADORINICIAL = @CONTADORINICIAL + 1
	END
END
DECLARE DB_CURSOR CURSOR FOR
SELECT CHAVE FROM @TABELACHAVE

DECLARE @CHAVE INT

OPEN DB_CURSOR FETCH NEXT FROM DB_CURSOR INTO @CHAVE

WHILE @@FETCH_STATUS = 0
BEGIN
	UPDATE Funcionario_Temp
	SET Situacao = 0
	WHERE ID_Funcionario_Temp = @CHAVE
    FETCH NEXT FROM DB_CURSOR INTO @CHAVE
   END
	CLOSE DB_CURSOR
	DEALLOCATE DB_CURSOR
END
GO



SELECT * FROM Funcionario_Temp WHERE Situacao = 0

SELECT COUNT(*) AS ATIVOS FROM Funcionario_Temp WHERE Situacao = 1
SELECT COUNT(*) AS INATIVOS FROM Funcionario_Temp WHERE Situacao = 0
