 DECLARE @CONTADOR INT
 SET @CONTADOR = 0
WHILE (@CONTADOR <> 10)
BEGIN
	PRINT 'VALOR DO CONTADOR =' + CONVERT(VARCHAR, @CONTADOR)
	SET @CONTADOR = @CONTADOR + 1
	IF (@CONTADOR = 5)
	BEGIN
		PRINT 'NÚMERO MÁGICO'
	END
END
	PRINT 'TERMINEI!!!'
GO