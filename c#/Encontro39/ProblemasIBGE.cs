using Atacado.FakeDB.RH;
using Atacado.Modelo.IBGE;
using Atacado.Modelo.RH;
using DesafiosDaGripe01.ProblemasFunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosDaGripe01
{
    public static class ProblemasIBGE
    {

        public static void Exercicio09(Estado estados)
        {
            Console.WriteLine("Código: {0} | Nome: {1} | Sigla: {2} ", estados.Codigo, estados.Descricao, estados.SiglaUF);
        }

        public static void Exercicio10(Municipio municipio)
        {
            Console.WriteLine("Código: {0} | Nome: {1} | Sigla: {2} ", municipio.Codigo, municipio.Descricao, municipio.SiglaUF);
        }

        public static void Exercicio11(Estado estados)
        {
            Console.WriteLine("Código: {0} | Nome: {1} | Sigla: {2} ", estados.Codigo, estados.Descricao, estados.SiglaUF);
        }

        public static Funcionario Exercicio12(int codigo)
        {
            Funcionario funcionario = FuncionarioFakeDB.Funcionarios.SingleOrDefault(pes => pes.Codigo == codigo);
            if (funcionario != null)
            {
                funcionario.Situacao = SituacaoEnum.Ativo;
                ProblemasFuncionario.Exercicio05(funcionario);
            }
            return funcionario;
        }

        public static Funcionario Exercicio13(int codigo)
        {
            Funcionario funcionario = FuncionarioFakeDB.Funcionarios.SingleOrDefault(pes => pes.Codigo == codigo);
            if (funcionario != null)
            {
                funcionario.Situacao = SituacaoEnum.Inativo;
                ProblemasFuncionario.Exercicio05(funcionario);
            }
            return funcionario;
        }
    }
}
