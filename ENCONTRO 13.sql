SCRIPT DE PROGRAMA PARA ESCREVER DATA

DECLARE @DATA DATETIME

SET @DATA = GETDATE()

SELECT 
	@DATA AS 'Data Atual',
	YEAR(@DATA) AS 'Ano Atual',
	MONTH(@DATA) AS 'Mês Atual',
	DAY(@DATA) AS 'Dia Atual',
	DATEPART(weekday, @DATA) AS 'Dia da Semana'
GO

____________________________________________________________________

CRIANDO STORED PROCEDURE = CREATE PROCEDURE

CREATE PROCEDURE SP_Obter_Data
AS
BEGIN
	DECLARE @DATA DATETIME
	SET @DATA = GETDATE()
	SELECT 
		@DATA AS 'Data Atual',
		YEAR(@DATA) AS 'Ano Atual',
		MONTH(@DATA) AS 'Mês Atual',
		DAY(@DATA) AS 'Dia Atual',
		DATEPART(weekday, @DATA) AS 'Dia da Semana'
END;
_______________________________________________________________________

ATIVIDADE DE CRIAR PROCEDURE

CREATE PROCEDURE SP_Obter_Informacoes_Completas_Por_Data_Admissao
 @ANO INT,
 @MES INT,
 @DIA INT
AS
BEGIN
SELECT 
	FDP.ID_Funcionario, 
	FDP.Matricula_Funcionario, 
	FDP.Nome_Funcionario, 
	FDP.Sobrenome_Funcionario, 
	FDE.Data_Admissao_Funcionario, 
	FDE.Ctps_Funcionario, 
	FDP.Sexo_Funcionario, 
	FDP.Datanasc_Funcionario, 
    FDP.Email_Funcionario
FROM Funcionarios_Dados_Empresa AS FDE INNER JOIN
    Funcionario_Dados_Pessoais AS FDP ON FDE.Matricula_Funcionario = FDP.Matricula_Funcionario	
	WHERE (FDP.Situacao = 1)
	AND YEAR(Data_Admissao_Funcionario) = @ANO
	AND MONTH(Data_Admissao_Funcionario) = @MES
	AND DAY(Data_Admissao_Funcionario) = @DIA
	ORDER BY Data_Admissao_Funcionario ASC
 END;

__________________________________________________________________



CREATE PROCEDURE SP_Dados_Completos_Por_Sexo_E_Data_Nascimento

 @SEXO CHAR(1),
 @ANO INT,
 @MES INT,
 @DIA INT
 AS
 BEGIN
SELECT 
	FDP.ID_Funcionario, 
	FDP.Matricula_Funcionario, 
	FDP.Nome_Funcionario, 
	FDP.Sobrenome_Funcionario, 
	FDE.Data_Admissao_Funcionario, 
	FDE.Ctps_Funcionario, 
	FDP.Sexo_Funcionario, 
	FDP.Datanasc_Funcionario, 
    FDP.Email_Funcionario
FROM Funcionarios_Dados_Empresa AS FDE INNER JOIN
    Funcionario_Dados_Pessoais AS FDP ON FDE.Matricula_Funcionario = FDP.Matricula_Funcionario	
	WHERE (FDP.Situacao = 1)
	AND (FDP.Sexo_Funcionario) = @SEXO
	AND YEAR(Data_Admissao_Funcionario) = @ANO
	AND MONTH(Data_Admissao_Funcionario) = @MES
	AND DAY(Data_Admissao_Funcionario) = @DIA
	ORDER BY Data_Admissao_Funcionario ASC
END;



CREATE PROCEDURE SP_Dados_Funcionario_Por_Matricula

@MATRICULA BIGINT
AS
BEGIN
SELECT 
	FDP.ID_Funcionario, 
	FDP.Matricula_Funcionario, 
	FDP.Nome_Funcionario, 
	FDP.Sobrenome_Funcionario, 
	FDE.Data_Admissao_Funcionario, 
	FDE.Ctps_Funcionario, 
	FDP.Sexo_Funcionario, 
	FDP.Datanasc_Funcionario, 
    FDP.Email_Funcionario
FROM Funcionarios_Dados_Empresa AS FDE INNER JOIN
    Funcionario_Dados_Pessoais AS FDP ON FDE.Matricula_Funcionario = FDP.Matricula_Funcionario	
	WHERE (FDP.Situacao = 1)
	AND (FDP.Matricula_Funcionario) = @MATRICULA
	ORDER BY Matricula_Funcionario 
END;

