INSERT INTO funcionario_dados_Pessoais( ID_Funcionario,Matricula_Funcionario,Nome_Funcionario,
Sobrenome_Funcionario,Sexo_Funcionario,Datanasc_Funcionario,Email_Funcionario,ID_Pais,Situacao,
DataInclusao,DataAlteracao,DataExclusao)
SELECT
	ID_Funcionario,
	CONVERT(BIGINT,Matricula_Funcionario) AS Matricula_Funcionario,
	Matricula_Funcionario,
	Nome_Funcionario,
	Sobrenome_Funcionario,
	Sexo_Funcionario,
	Datanasc_Funcionario,
	Email_Funcionario,
	ID_Pais,
	Situacao,
	DataInclusao,
	DataAlteracao,
	DataExclusao
FROM Funcionario

CREATE TABLE Funcionario_Dados_Pessoais(
	      ID_Funcionario BIGINT NOT NULL,
	      Matricula_Funcionario BIGINT NOT NULL,
	      Nome_Funcionario varchar (50) NOT NULL,
	      Sobrenome_Funcionario varchar (50) NOT NULL,
	      Sexo_Funcionario char (1) NOT NULL,
	      Datanasc_Funcionario datetime NOT NULL,
	      Email_Funcionario varchar(MAX) NOT NULL,
	      ID_Pais int NOT NULL,
	      Situacao bit NULL DEFAULT 1,
	      DataInclusao datetime NULL DEFAULT GETDATE(),
	      DataAlteracao  datetime NULL,
	      DataExclusao datetime NULL,
 CONSTRAINT PK_FuncDadosPessoais PRIMARY KEY ( ID_Funcionario )
 )
