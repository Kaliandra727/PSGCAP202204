CREATE TABLE _Funcionarios_Dados Empresa(
ID_FuncDadosEmpresa BIGINT NOT NULL IDENTITY (1,1),
Matricula_Funcionario BIGINT NOT NULL,
Nome_Funcionario VARCHAR(50) NOT NULL,
Sobrenome_Funcionario varchar(50) NOT NULL,
Data_Admissao_Funcionario datetime NOT NULL,
Ctps_Funcionario varchar(50) NOT NULL,
Ctps_Num_Funcionario bigint NOT NULL,
Ctps_Serie_Funcionario int NOT NULL
Situacao bit NULL DEFAULT 1,
DataInclusao datetime NULL DEFAULT GETDATE(),
DataAlteracao datetime NULL,
DataExclusao datetime NULL,
	CONSTRAINT PK_FuncDadosEmpresa PRIMARY KEY (ID_FuncDadosEmpresa)
) ON PRIMARY      
GO

