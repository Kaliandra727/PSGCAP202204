using Atacado.FakeDB.RH;
using Atacado.Modelo.RH;
using DesafioDaGripe01.Matematica;
using DesafioDaGripe01.ProblemaFunc;

public class Program
{
    public static void Main(string[] args)
    {
        ExecutarExercicio();
        ExecutarExercicio02();
        ExecutarExercicio03();
        ExecutarExercicio04();
        ExecutarExercicio05();
        ExecutarExercicio06();
        ExecutarExercicio07();
        ExecutarExercicio08();

    }

    public static void ExecutarExercicio()
    {
        Console.WriteLine("Qual a operação matemática? (0 - Adição , 1- Subtração , 2 - Multiplicação , 3 - Divisão)");
        int Menu = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o prmeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        switch (Menu)
        {
            case 0:
                result = ProblemasMatematicos.Exercicio01(Operacoes.Adicao, num1, num2);
                break;
            case 1:
                result = ProblemasMatematicos.Exercicio01(Operacoes.Subtracao, num1, num2);
                break;
            case 2:
                result = ProblemasMatematicos.Exercicio01(Operacoes.Multiplicacao, num1, num2);
                break;
            case 3:
                result = ProblemasMatematicos.Exercicio01(Operacoes.Divisao, num1, num2);
                break;
            default:
                break;
        }
        Console.WriteLine("Resultado da equação é: {0} ", result);
    }

    public static void ExecutarExercicio02()
    {
        Console.WriteLine("Digite o comprimento do retângulo: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a largura do retângulo: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a altura do retângulo: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        ProblemasMatematicos.Exercicio02(num1, num2, num3);
    }

    public static void ExecutarExercicio03()
    {
        Console.WriteLine("Digite a altura do cilindro: ");
        int num1 = Convert.ToInt32((Console.ReadLine()));
        Console.WriteLine("Digite o raio do cilindro: ");
        int num2 = Convert.ToInt32((Console.ReadLine()));
        ProblemasMatematicos.Exercicio03(num1, num2);
    }


    public static void ExecutarExercicio04()
    {
        Console.WriteLine("Diigite o raio de esfera: ");
        int num1 = Convert.ToInt32((Console.ReadLine()));
        ProblemasMatematicos.Exercicio04(num1);
    }

    public static void ExecutarExercicio05()
    {
        Console.WriteLine("Digite um código de funcionário (de 1 a 100): ");
        int codigo = Convert.ToInt32(Console.ReadLine());
        List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(empregado => empregado.Codigo == codigo).ToList();
        foreach (Funcionario i in funcionario)
        {
            ProblemasFuncionario.Exercicio05(i);
        }
    }

    public static void ExecutarExercicio06()
    {
        Console.WriteLine("Digite o peso do funcionário: ");
        float pe = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Digite a altura do funcionário: ");
        float alt = Convert.ToSingle(Console.ReadLine());
        ProblemasFuncionario.Exercicio06(pe, alt);
    }

    public static void ExecutarExercicio07()
    {
        Console.WriteLine("Digite um código de funcionário (máx: 100): ");
        int cod = Convert.ToInt32(Console.ReadLine());
        List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(pes => pes.Codigo == cod).ToList();
        foreach (Funcionario i in funcionario)
        {
            ProblemasFuncionario.Exercicio07(i);
        }
    }

    public static void ExecutarExercicio08()
    {
        Console.WriteLine("Digite um código de funcionário (máx: 100): ");
        int codigo = Convert.ToInt32(Console.ReadLine());
        List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(pes => pes.Codigo == codigo).ToList();
        foreach (Funcionario i in funcionario)
        {
            ProblemasFuncionario.Exercicio08(i);
        }
    }
}
