--CREATE TABLE Exercicio(
--ID_Exercicio INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
--Nome_Exercicio VARCHAR(MAX) NOT NULL,
--Idade_Exercicio INT NULL,
--Nota_Exercicio DECIMAL(3,2) NULL,
--Situacao BIT NULL DEFAULT 1,
--DataInclusao DATETIME NULL DEFAULT GETDATE()
--)

--INSERT INTO Exercicio (Nome_Exercicio,Idade_Exercicio,Nota_Exercicio)
--VALUES
--	('TESTE 001',    18, 7.5),
--	('PROVA 002',    20, 9.5),
--	('FULANO 003',   19, 5.7),
--	('PASTA 004',    30, 3.5),
--	('CACHORRO 005',  9, 8.4),
--	('GATO 006',     60, 2.1),
--	('MOTO 007',     90, 6.1),
--	('SPFC 008',     70, 9.9),
--	('MACACO 009',    5, 3.7),
--	('PARIS 010',    50, 1.2),
--	('BOTA 011',     40, 8.2),
--	('RAQUETE 012',  87, 7.0)
--GO

--SELECT * FROM Exercicio;

--SELECT * 
--FROM Exercicio
--WHERE Idade_Exercicio BETWEEN 18 AND 23
--GO

--SELECT * FROM Exercicio
--WHERE Idade_Exercicio >= 18


--ALTER TABLE Exercicio
--ALTER COLUMN 
--	Nota_Exercicio decimal (7,2)
--GO

--SELECT * FROM Exercicio
--WHERE Idade_Exercicio= 23;


--UPDATE Exercicio
--SET Situacao = 0
--WHERE Idade_Exercicio <= 18
--go


--UPDATE Exercicio
--SET Idade_Exercicio = 15
--WHERE Nota_Exercicio < 6;

--ALTER TABLE Exercicio
--	ADD 
--		Estado_Atual_Exercicio CHAR(1) 
--GO

--UPDATE Exercicio
--SET Estado_Atual_Exercicio = 'R'
--WHERE Nota_Exercicio < 6;


--UPDATE Exercicio
--SET Estado_Atual_Exercicio = 'A'
--WHERE Nota_Exercicio > 6;

