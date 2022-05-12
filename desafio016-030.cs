  public static void Desafio_016()
        {
            Console.Write("Digite um número:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("O número digitado é par.");
            }
            else
            {
                Console.WriteLine("O número digitado é ímpar.");
            }
        }

        static void Desafio_017()
        {
            Console.WriteLine("Digite seu primeiro nome:");
            string firstnome = Console.ReadLine();
            Console.WriteLine("Digite seu segundo nome:");
            string segnome = Console.ReadLine();
            int soma = firstnome.Count() + segnome.Count();
            Console.WriteLine("olá meu nome é : {0} {1}.", firstnome, segnome);
            Console.WriteLine(firstnome.ToUpper() + " " + segnome.ToUpper());
            Console.WriteLine(firstnome.ToLower() + " " + segnome.ToLower());
            Console.WriteLine("Ao todo o nome possui {0} letras", soma);
            Console.WriteLine("O primeiro nome possui {0} letras", firstnome.Count());
        }

        public static void Desafio_018()
        {
            Console.Write("Sua conta será de  multiplicação(1), soma(2), divisão(3), subtração(4) ? ");
            int simbo = Convert.ToInt32(Console.ReadLine());
            if (simbo == 2)
            {
                Console.Write("Digite um valor para conta: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo valor:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int resulmais = num1 + num2;
                Console.WriteLine("O resultado da soma é = {0}.", resulmais);
                Console.ReadLine();
            }
            if (simbo == 4)
            {
                Console.Write("Digite um valor para conta: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo valor:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int resulmais = num1 - num2;
                Console.WriteLine("O resultado da subtração é = {0}.", resulmais);
                Console.ReadLine();
            }
            if (simbo == 1)
            {
                Console.Write("Digite um valor para conta: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo valor:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int resulmais = num1 * num2;
                Console.WriteLine("O resultado da multiplicação é = {0}.", resulmais);
                Console.ReadLine();
            }
            if (simbo == 3)
            {
                Console.Write("Digite um valor para conta: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo valor:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int resulmais = num1 / num2;
                Console.WriteLine("O resultado da divisão é = {0}.", resulmais);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("A informação digitada não é válida");
            }
        }

        static void Desafio_019()
        {
            Console.Write("Digie a sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não tem permissão!");
            }
            if (idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão concedida!");
            }
        }

        static void Desafio_020()
        {
            Console.Write("Escreva uma frase:");
            string frase = Console.ReadLine();
            string result = frase.Replace("a", "&").Replace("A", "&");
            Console.WriteLine("Após trocar todos os 'A' por 'E' : {0}", result);
        }

        static void Desafio_021()
        {
            Console.Write("Digite seu salário: ");
            double sal = Convert.ToDouble(Console.ReadLine());
            if (sal <= 1700)
            {
                double result = sal + 300;
                Console.WriteLine("O reajuste foi de R$ 300,00 seu salário ficou no valor de {0} reais.", result);
            }
            if (sal > 1700)
            {
                double result1 = sal + 200;
                Console.WriteLine("O reajuse foi de R$ 200,00 seu salário ficou no valor de {0} reais.", result1);
            }
        }

        static void Desafio_022()
        {
            Console.Write("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double alt = altura * altura;
            double imc = (peso / alt);
            Console.WriteLine("Seu IMC é : {0}.", imc);
        }

        static void Desafio_023()
        {
            Console.Write("Quanto é a altura do retângulo? ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quanto é a largura do retângulo? ");
            double larg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quanto é o comprimento? ");
            double compri = Convert.ToDouble(Console.ReadLine());
            double result = compri * larg * altura;
            Console.WriteLine("O volume do retângulo é {0}.", result);
        }

        static void Desafio_024()
        {
            Console.WriteLine("Quanto é a altura do cilindro? ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quanto é o raio do cilindro? ");
            double raio = Convert.ToDouble(Console.ReadLine());
            double pi0 = 3.14;
            double raio1 = raio * raio;
            double volume = (pi0 * raio1 * altura);
            Console.WriteLine("O volume do cilindro é {0}.", volume);
        }

        static void Desafio_025()
        {
            Console.WriteLine("Digite um número qualquer:");
            double um = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro número");
            double dois = Convert.ToInt32(Console.ReadLine());
            double diferenca = (um - dois);
            if (dois < um)
            {
                double result = Math.Pow(diferenca, 2);
                Console.WriteLine("O quadrado dos valores digitados são {0}.", result);
            }
        }

        static void Desafio_026()
        {
            Console.Write("Qual o valor do raio? ");
            double raio = Convert.ToDouble(Console.ReadLine());
            double raio1 = Math.Pow(raio, 3);
            double um = 1.33;
            double pi0 = 3.14;
            double cal = um * pi0 * raio1;
            Console.WriteLine("O volume da esfera é: {0}.", cal);
        }

        static void Desafio_027()
        {
            Console.Write("Digite um número: ");
            double um = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite outro número: ");
            double dois = Convert.ToDouble(Console.ReadLine());
            double soma = (um + dois);
            double divisao = (um / dois);
            double sub = (um - dois);
            double multi = (um * dois);
            Console.WriteLine("-> soma = {0}", soma);
            Console.WriteLine("-> divisão = {0}", divisao);
            Console.WriteLine("-> subtração = {0}", sub);
            Console.WriteLine("-> multiplicação = {0}", multi);
        }

        static void Desafio_028()
        {
            Console.Write("Quantos litros foram colocados no veículo? ");
            double gasol = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantos Km foram rodados? ");
            double km = Convert.ToDouble(Console.ReadLine());
            double cont = km / gasol;
            Console.WriteLine("O seu carro teve o consumo de {0}km/l.", cont);
        }

        static void Desafio_029()
        {
            Console.WriteLine("Qual o valor inicial da fatura? ");
            double inicial = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor da taxa de juros? ");
            double taxa = Convert.ToDouble(Console.ReadLine());
            Console.Write("A quantos meses não paga a prestação? ");
            double temp = Convert.ToDouble(Console.ReadLine());
            double cont = inicial * taxa * temp;
            Console.WriteLine("O preço da fatura com juros é: {0} reais.", cont);
        }

        static void Desafio_030()
        {
            int numqtde = 5;
            int pmenor = 0;
            int pmaior = 0;
            int maior = 0;
            int menor = 0;
            int[] numero = new int[numqtde];
            for (int i = 0; i <= numqtde; i++)
            {
                Console.WriteLine("Digite um número: ");
                int num = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (numero[i] < menor)
                {
                    maior = numero[i];
                    pmaior = i;
                }
                if (numero[i] > maior)
                {
                    menor = numero[i];
                    pmenor = i;
                }
            }
                Console.WriteLine("maior número é:" + maior);
                Console.WriteLine("menor número é:"+ menor);
            
        }
