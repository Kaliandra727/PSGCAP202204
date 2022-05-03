INSERT INTO Municipio1(ID_Municipio, Nome_Municipio, ID_UF, Sigla_UF, ID_Mesoregiao, ID_Microregiao, Populacao, Porte, Cod_Ibge7, Cod_Ibge, Cep)
SELECT       
MU.MunicipioID, 
MU.Nome, 
MU.UFID, 
LM.UF, 
MU.MesoregiaoID, 
MU.MicroregiaoID, 
LM.Populacao_2010,
LM.Porte, LM.IBGE7, 
LM.IBGE, 
CI.CEP
FROM RAW_DATA_Municipio AS MU INNER JOIN
RAW_DATA_Lista_de_Municipio AS LM ON MU.CodigoIBGE = LM.IBGE7 LEFT OUTER JOIN
 RAW_DATA_Cidade AS CI ON LM.IBGE = CI.IBGE
