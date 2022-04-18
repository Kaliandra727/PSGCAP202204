--SELECT * FROM Exercicio WHERE (Situacao = 1)

--SELECT * FROM Exercicio WHERE Nota_Exercicio < 4


--UPDATE Exercicio
--SET
--	Situacao = 0,
--	DataAlteracao = GETDATE(),
--	DataExclusao = GETDATE()
--WHERE 
--	Nota_Exercicio < 4
--GO

--	ALTER TABLE Exercicio
--	ADD
--		DataAlteracao DATETIME NULL,
--		DataExclusao DATETIME NULL
--GO
