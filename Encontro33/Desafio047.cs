using CapConsoleApp2.EstudoPOO;
using Modelos;
using FakeDB.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapConsoleApp2.Desafio
{
    public class DesafioDojo2
    {
        private List<Estado> listaEstadosRegiaoSelecionada;
        private List<Municipio> listaConsultarMunicipioPeloNome;
        private List<Estado> estados;
        private List<Estado> sigla;
        private List<Municipio> listaMunicipioPorEstado;
        private List<Municipio> pesquisarMunicipioPorIBGE7;
        private List<Municipio> pesquisarMunicipioPorCep;

        public DesafioDojo2()
        {

        }

        public void Executar()
        {
            this.PesquisarPorNome();
            this.PesquisarPorSigla();
            this.ListarEstadosRegiao();
            this.ConsultarMunicipioPeloNome();
            this.ListarMunicipiosPorEstado();
            this.PesquisarMunicipioPorIBGE7();
            this.PesquisarMunicipioPorCep();
        }

        /// <summary>
        /// KALI
        /// </summary>
        private void PesquisarPorNome()
        {
            while (true)
            {
                Console.WriteLine("-- EXERCÍCIO 01 --");
                Console.Write("Digite o nome de um Estado: ");
                string nome = Console.ReadLine();
                this.estados = FakeDB.IBGE.EstadoFakeDB.Estado.Where(pes => pes.NomeEstado.StartsWith(nome)).ToList();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("número de estados encontrados: {0}.", this.estados.Count());
                Console.ResetColor();
                foreach (Estado item in this.estados)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("- Estado encontrado -");
                    item.ImprimirSigla();
                    item.ImprimirRegiao();
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Deseja passar para o próximo exercício? (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.ResetColor();
            }
        }

        private void PesquisarPorSigla()
        {
            Console.Clear();
            Console.WriteLine("-- EXERCÍCIO 02 --");
            while (true)
            {
                Console.Write("Digite uma Sigla de Estado: ");
                string nome = Console.ReadLine();
                if (nome.Length != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sigla não encontrada, digite novamente!");
                    Console.ResetColor();
                }
                this.sigla = FakeDB.IBGE.EstadoFakeDB.Estado.Where(pes => pes.Siglauf == nome).ToList();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("número de Siglas encontradas: {0}.", this.sigla.Count());
                Console.ResetColor();
                foreach (Estado item in this.sigla)
                {
                    Console.WriteLine("- Sigla encontrada -");
                    item.ImprimirSigla();
                    item.ImprimirRegiao();
                }
                Console.Write("Deseja passar para o próximo exercício? (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
            }
        }

        /// <summary>
        /// NELIO
        /// </summary>
        private void ListarEstadosRegiao()
        {
            Console.Clear();
            Console.WriteLine("-- EXERCÍCIO 03 --");
            while (true)
            {
                Console.WriteLine("-Lista para mostrar todos os estados da região desejada-");
                Console.WriteLine("Escolha a região desejada: ");
                string regiao = Console.ReadLine();
                this.listaEstadosRegiaoSelecionada = FakeDB.IBGE.EstadoFakeDB.Estado
                    .Where(pes => pes.NomeRegiao.ToUpper() == regiao || pes.NomeRegiao.ToLower() == regiao || pes.NomeRegiao == regiao)
                    .ToList();
                Console.WriteLine("Estados da regiao {0}:", regiao);
                foreach (Estado item in this.listaEstadosRegiaoSelecionada)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    item.ImprimirSigla();
                    item.ImprimirRegiao();
                    Console.ResetColor();
                }
                if (this.listaEstadosRegiaoSelecionada.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Essa região não existe.");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Deseja passar para o próximo exercício? (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.ResetColor();
            }
        }

        /// <summary>
        /// LUCAS
        /// </summary>
        private void ConsultarMunicipioPeloNome()
        {
            Console.WriteLine("-- EXERCÍCIO 04 --");
            while (true)
            {
                Console.Write("Qual o município que você procura? >");
                string nomem = Convert.ToString(Console.ReadLine());

                this.listaConsultarMunicipioPeloNome = MunicipioFakeDB.Municipios.Where(pes => pes.NomeMunicipio.StartsWith(nomem)).ToList();
                foreach (Municipio item in this.listaConsultarMunicipioPeloNome)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    item.ImprimirSigla();
                    Console.ResetColor();

                }
                if (this.listaConsultarMunicipioPeloNome.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não existe ninguem com esse nome");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Deseja passar para o próximo exercício? (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.ResetColor();
            }
        }

        /// <summary>
        /// MATHEUS
        /// </summary>
        public void ListarMunicipiosPorEstado()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("-- EXERCÍCIO 05 --");
                Console.WriteLine("Digite a sigla do estado (ex: RO): ");
                string opcao = Console.ReadLine();
                this.listaMunicipioPorEstado = MunicipioFakeDB.Municipios.Where(pes => pes.Siglauf == opcao).ToList();
                if (this.listaMunicipioPorEstado.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não existem dados a serem exibidos.");
                    Console.ResetColor();
                }
                else
                {
                    foreach (Municipio item in this.listaMunicipioPorEstado)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        item.ImprimirSigla();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Total de Registros: {0}", this.listaMunicipioPorEstado.Count());
                Console.Write("Deseja passar para o próximo exercício? (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.ResetColor();
            }
        }

        /// <summary>
        /// ANDRESSA
        /// </summary>
        public void PesquisarMunicipioPorIBGE7()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("-- EXERCÍCIO 06 --");
                Console.WriteLine("Digite o Código do IBGE: ");
                int resposta = Convert.ToInt32(Console.ReadLine());
                this.pesquisarMunicipioPorIBGE7 = MunicipioFakeDB.Municipios.Where(pes => pes.Ibge7 == resposta).ToList();
                if (this.pesquisarMunicipioPorIBGE7.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não existem dados a serem exibidos.");
                    Console.ResetColor();

                }
                else
                {
                    foreach (Municipio item in this.pesquisarMunicipioPorIBGE7)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        item.ImprimirSigla();
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Total de Registros: {0}", this.pesquisarMunicipioPorIBGE7.Count());
                Console.Write("Deseja passar para o próximo exercício? (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.ResetColor();
            }
        }

        public void PesquisarMunicipioPorCep()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("-- EXERCÍCIO 07 --");
                Console.WriteLine("Digite o CEP: ");
                int resposta = Convert.ToInt32(Console.ReadLine());
                this.pesquisarMunicipioPorCep = MunicipioFakeDB.Municipios.Where(pes => pes.Cep == resposta).ToList();
                if (this.pesquisarMunicipioPorCep.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não existem dados a serem exibidos.");
                    Console.ResetColor();
                }
                else
                {
                    foreach (Municipio item in this.pesquisarMunicipioPorCep)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        item.ImprimirSigla();
                        Console.ResetColor();
                    }

                }
                Console.WriteLine("Total de Registros: {0}", this.pesquisarMunicipioPorCep.Count());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Deseja passar para o próximo exercício? (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-- FIM DOS EXERCÍCIOS --");
            Console.ResetColor();
        }
    }
}
