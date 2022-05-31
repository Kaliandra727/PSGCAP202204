using Atacado.Modelo.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDaGripe01.ProblemaFunc
{
    public static class ProblemasFuncionario
    {
        public static void Exercicio05(Funcionario empregado)
        {
            Console.WriteLine("Código: {0} | Nome: {1} | Sobrenome {2} | Idade: {3} ", empregado.Codigo , empregado.Nome, empregado.SobreNome, empregado.Idade);
        }

        public static void Exercicio06(float pe, float alt)
        {
            double IMC = pe * Math.Pow(alt, 2);
            Console.WriteLine(" O IMC é: {0}", IMC);
        }

        public static void Exercicio07(Funcionario empregado)
        {
            int id = 0;
            if (empregado.DtNascimento.DayOfWeek < DateTime.Today.DayOfWeek)
            {
                id = DateTime.Today.Year - empregado.DtNascimento.Year - 1;
            }
            else
            {
                id = DateTime.Today.Year - empregado.DtNascimento.Year;
            }
            Console.WriteLine("Nome: {0} {1}.", empregado.Nome, empregado.SobreNome);
            Console.WriteLine("Idade: {0}", id);
        }

        public static void Exercicio08(Funcionario empregado)
        {
            bool status;
            int id = 0;
            Exercicio07(empregado);

            if (empregado.DtNascimento.DayOfWeek < DateTime.Today.DayOfWeek)
            {
                id = DateTime.Today.Year - empregado.DtNascimento.Year - 1;
            }
            else
            {
                id = DateTime.Today.Year - empregado.DtNascimento.Year;
            }
            if (id > 65 && empregado.Sexo == "M" )
            {
                status = true;
                Console.WriteLine("Pode se aposentar? {0}.", status);
            }
            else if (id < 60 && empregado.Sexo == "F"  )
            {
                status = true;
                Console.WriteLine("Pode se aposentar? {0}.", status);
            }
            else
            {
                status = false;
                Console.WriteLine("Pode se aposentar? {0}", status);
            }
        }

    }
}
