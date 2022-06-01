
        public static void ExecutarExercicio09()
        {
            Console.WriteLine("- ACHE ESTADO PELA SIGLA -");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite a sigla de um estado: ");
            string sigla = Console.ReadLine();
            Console.ResetColor();
            List<Estado> estados = EstadoFakeDB.Estados.Where(estado => estado.SiglaUF == sigla).ToList();
            if(estados.Count() == 0 && estados.Count != 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Estado não encontrado");
                Console.ResetColor();
            }
            foreach (Estado i in estados)
            {
                    Console.ForegroundColor = ConsoleColor.Green;
                    ProblemasIBGE.Exercicio09(i);
                    Console.ResetColor();
            }

        }


        public static void ExecutarExercicio10()
        {
            Console.Clear();
            Console.WriteLine("- MUNICÍPIOS DE UM ESTADO PELA SIGLA -");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite a sigla de um estado: ");
            string sigla = Console.ReadLine();
            Console.ResetColor();
            List<Municipio> municipios = MunicipioFakeDB.Municipios.Where(municipios => municipios.SiglaUF.StartsWith(sigla)).ToList();
            if (municipios.Count() == 0 && municipios.Count != 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Estado não encontrado");
                Console.ResetColor();
            }
            foreach (Municipio i in municipios)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                ProblemasIBGE.Exercicio10(i);
                Console.ResetColor();
            }
        }

        public static void ExecutarExercicio11()
        {
            Console.Clear();
            Console.WriteLine("- ACHE ESTADOS PELO NOME DA REGIÃO -");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite uma região: ");
            string regiao = Console.ReadLine();
            Console.ResetColor();
            List<Estado> estados = EstadoFakeDB.Estados.Where(estados => estados.RegiaoBrasil.StartsWith(regiao)).ToList();
            if (estados.Count() == 0 && estados.Count != 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Estado não encontrado");
                Console.ResetColor();
            }
            foreach (Estado i in estados)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                ProblemasIBGE.Exercicio11(i);
                Console.ResetColor();
            }
        }

        public static void ExecutarExercicio12()
        {
            Console.Clear();
            Console.WriteLine("- ATIVANDO FUNCIONÁRIOS -");
            Console.WriteLine("Digite um código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ProblemasIBGE.Exercicio12(codigo);
        }

        public static void ExecutarExercicio13()
        {
            Console.Clear();
            Console.WriteLine("- DESATIVANDO FUNCIONÁRIOS -");
            Console.WriteLine("Digite um código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ProblemasIBGE.Exercicio13(codigo);
        }
