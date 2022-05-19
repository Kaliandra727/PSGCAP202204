 public class Desafio045
    {
        private List<Pessoa> listaMes;

        private List<Pessoa> listaA;

        private List<Pessoa> listaNascidosDecada1960;

        private List<Pessoa> listaNascidosDecada1975A80;

        private List<Pessoa> listaPorNome;

        private List<Pessoa> listaAno;

        private List<Pessoa> Decada60;

        private List<Pessoa> Entre5560;

        public Desafio045()
        {
            this.listaMes = new List<Pessoa>();
            this.listaA = new List<Pessoa>();
            this.listaNascidosDecada1960 = new List<Pessoa>();
            this.listaNascidosDecada1975A80 = new List<Pessoa>();
            this.listaPorNome = new List<Pessoa>();
            this.listaAno = new List<Pessoa>();
            this.Decada60 = new List<Pessoa>();
            this.Entre5560 = new List<Pessoa>();
        }

        public void Executar()
        {
            PreencherLista60();
            //PreencherLista5560();
            //PreencherListaMes();
            //PreencherListaNomesA();
            //PesquisarPorNome();
            //PesquisaPorAno();
            //HomensDecada60();
            //Mulheres5560();
        }


        private void PreencherLista60()
        {
            int ano = 1960;
            int ano2 = 1970;
            this.listaNascidosDecada1960 = PessoaFakeDB.Pessoa
                .Where(pes => (pes.DtNascimento.Year >= ano))
                .Where(pes => (pes.DtNascimento.Year <= ano2))
                .ToList();
            foreach (Pessoa item in this.listaNascidosDecada1960)
            {
                Console.WriteLine("Codigo: {0} | Nome: {1} | Dt Nasc: {2}", item.Codigo, item.Nome, item.DtNascimento);
            }
            Console.WriteLine(" Pessoas nascidas na década de 60: {0} ", this.listaNascidosDecada1960.Count()); 
        }

        private void PreencherLista5560()
        {
            DateTime data = Convert.ToDateTime("01-01-1955");
            DateTime data2 = Convert.ToDateTime("31-12-1960");
            this.listaNascidosDecada1975A80 = PessoaFakeDB.Pessoa.Where(pes => pes.DtNascimento >= data && pes.DtNascimento < data2).ToList();
            Console.WriteLine("- Pessoas nascidas entre 1955 e 1960 = {0}.", this.listaNascidosDecada1975A80.Count());
        }

        private void PreencherListaMes()
        {
            Console.WriteLine("Digite o mês desejado: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            this.listaMes = PessoaFakeDB.Pessoa.Where(pes => pes.DtNascimento.Month == mes).ToList();
            Console.WriteLine("Pessoas nascidas no mes {0}", mes);
            foreach (Pessoa item in this.listaMes)
            {
                Console.WriteLine("Nome: {0} {1} | Data de nascimento: {2}.", item.Nome, item.SobreNome, item.DtNascimento);
            }
        }

        private void PreencherListaNomesA()
        {
            this.listaA = PessoaFakeDB.Pessoa.Where(pes => pes.Nome[0] == 'A').ToList();
            Console.WriteLine("Nomes que começam com A = {0}", this.listaA.Count());
            foreach (Pessoa item in this.listaA)
            {
                Console.WriteLine("Nome: {0} {1}.", item.Nome, item.SobreNome);
            }
        }

        private void PesquisarPorNome()
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();
            this.listaPorNome = PessoaFakeDB.Pessoa.Where(pes => pes.Nome.Contains(nome)).ToList();
            foreach (var item in this.listaPorNome)
            {
                Console.WriteLine("- Nomes encontrados -");
                Console.WriteLine("{0} {1}",item.Nome, item.SobreNome);
            }

        }

        private void PesquisaPorAno()
        {
            Console.WriteLine("Digite o ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            this.listaAno = PessoaFakeDB.Pessoa.Where(pes => pes.DtNascimento.Year == ano).ToList();
            Console.WriteLine("- Pessoas nascidas neste ano -");
            foreach (Pessoa item in this.listaAno)
            {
                Console.WriteLine("{0} {1}", item.Nome, item.SobreNome);
            }
        }

        private void HomensDecada60()
        {
            this.Decada60 = PessoaFakeDB.Pessoa.Where(pes => pes.Sexo == "M").ToList();
            Console.WriteLine("- Homens nascidos na Década de 60 -");
            foreach (var item in this.Decada60)
            {
                Console.WriteLine("{0} {1}| SEXO: {2} | DATA: {3}.", item.Nome, item.SobreNome, item.Sexo, item.DtNascimento);
            }
        }

        private void Mulheres5560()
        {
            this.Entre5560 = PessoaFakeDB.Pessoa.Where(pes => pes.Sexo == "F").ToList();
            Console.WriteLine("- Mulheres nascidas entre 1955 e 1960 -");
            foreach (var item in this.Entre5560)
            {
                Console.WriteLine("{0} {1} | SEXO: {2} | DATA: {3}.", item.Nome, item.SobreNome, item.Sexo, item.DtNascimento);
            }
        }
    }
