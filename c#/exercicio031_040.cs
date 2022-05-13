static void Desafio_031()
        {
            Console.Write("Digite um número:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Multiplo de 2!");
                Console.WriteLine("O número digitado é par.");
            }
            else
            {
                Console.WriteLine("O número digitado é ímpar.");
            }
            if (num % 3 == 0)
            {
                Console.WriteLine("Multiplo de 3!");
            }
            if (num % 5 == 0)
            {
                Console.WriteLine("Multiplo de 5!");
            }
        }

        public static List<string> listaNomes20()
        {
            List<string> listaNomes20 = new List<string>();
            listaNomes20.Add("Neymar");
            listaNomes20.Add("Vinícius");
            listaNomes20.Add("Cristiano");
            listaNomes20.Add("Messi");
            listaNomes20.Add("Bale");
            listaNomes20.Add("Alisson");
            listaNomes20.Add("Halland");
            listaNomes20.Add("Modríc");
            listaNomes20.Add("Pogba");
            listaNomes20.Add("Benzema");
            listaNomes20.Add("Coutinho");
            listaNomes20.Add("Calleri");
            listaNomes20.Add("Rodrigo");
            listaNomes20.Add("Suaréz");
            listaNomes20.Add("Firmino");
            listaNomes20.Add("Ronaldinho");
            listaNomes20.Add("Casemiro");
            listaNomes20.Add("Marta");
            listaNomes20.Add("Luciano");
            listaNomes20.Add("Salah");
            return listaNomes20;
        }

        static void Desafio_032()
        {
            List<string> lista = listaNomes20();
            List<int> idade = new List<int>();
            for (int i = 0; i < lista.Count(); i++)
            {
                Console.Write("Digite a idade do aluno {0}: ", lista[i]);
                idade.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int total = 0;
            foreach (int s in idade)
            {
                total = total + s;
            }
            float media = total / lista.Count();
            for (int x = 0; x < lista.Count(); x++)
            {
                Console.WriteLine("aluno {0}, idade {1}.", lista[x], idade[x]);
            }
            Console.WriteLine("A média de idade dos jogadores: {0}", media);
        }

        static void Desafio_033()
        {
            List<string> lista = listaNomes20();
            List<int> idade = new List<int>();
            int contador = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite a idade do aluno {0}: ", lista[i]);
                idade.Add(Convert.ToInt32(Console.ReadLine()));
                if (idade[i] > 18)
                {
                    contador++;
                }
            }
            Console.WriteLine("{0} alunos possuem mais 18 anos.", contador);
        }

        static void Desafio_034()
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine("O resultado é = {0}.", soma);
        }

        static void Desafio_035()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + ",");
                }
            }
        }

        static void Desafio_036()
        {
            List<string> lista = listaNomes20();
            List<int> idade = new List<int>();
            List<string> pais = new List<string>();
            int contador = 0;
            int cont = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.Write("Digite a idade do aluno {0}: ", lista[i]);
                idade.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Digite a nacionalidade do aluno {0}: ", lista[i]);
                pais.Add(Console.ReadLine());
                if (idade[i] >= 16 && (pais[i] == "brasileiro" || pais[i] == "brasileira"))
                {
                    contador++;
                }
                else
                {
                    cont++;
                }
            }
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("aluno {0}, idade {1}, nacionalidade {2}.", lista[x], idade[x], pais[x]);
            }
            Console.WriteLine("{0} alunos podem votar .", contador);
            Console.WriteLine("{0} alunos não podem votar.", cont);
        }

        static void Desafio_037()
        {

            List<string> lista = listaNomes20();
            List<float> salario = new List<float>();
            List<double> rejust = new List<double>();
            for (int i = 0; i < lista.Count(); i++)
            {
                Console.Write("Digite o salário do funcionário {0}: ", lista[i]);
                salario.Add(Convert.ToSingle(Console.ReadLine()));
                if (salario[i] <= 300)
                {
                    double reajuste = salario[i] * 0.5;
                    rejust.Add(salario[i] + reajuste);
                }
                else
                {
                    double reajuste = salario[i] * 0.3;
                    rejust.Add(salario[i] + reajuste);
                }
            }
            for (int x = 0; x < lista.Count(); x++)
            {
                Console.WriteLine("Funcionário {0}, salário reajustado {1} reais.", lista[x], rejust[x]);
            }
        }

        static void Desafio_038()
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma = soma + i;
                    Console.WriteLine(i);
                }
            }
            Console.Write(soma);
        }

        static void Desafio_039()
        {
            for (int i = 1; i < 120; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    Console.WriteLine(i + ",");
                }
            }
        }

        static void Desafio_040()
        {
            List<string> lista = listaNomes20();
            List<float> altura = new List<float>();
            List<double> matricula = new List<double>();
            double maior = 0;
            double menor = 0;
            double codmais = 0;
            double codmeno = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite a altura do aluno {0}: ", lista[i]);
                altura.Add(Convert.ToSingle(Console.ReadLine()));
                Console.WriteLine("digite o número da matrícula do aluno {0}: ", lista[i]);
                matricula.Add(1000 + i);
                if (i == 0)
                {
                    maior = altura[i];
                    menor = altura[i];
                    codmais = matricula[i];
                    codmeno = matricula[i];
                }
                else if (altura[i] > maior)
                {
                    maior = altura[i];
                    codmais = matricula[i];
                }
                else if (altura[i] < menor)
                {
                    menor = altura[i];
                    codmeno = matricula[i];
                }
            }
                Console.WriteLine("O aluno mais baixo possui {0} de altura, múmero de matrícula = {1}", menor, codmeno);
                Console.WriteLine("O aluno mais alto possui {0} de altura, múmero de matrícula = {1}", maior, codmais);
        }
