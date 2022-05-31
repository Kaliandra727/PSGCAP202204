using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDaGripe01.Matematica
{
    public static class ProblemasMatematicos
    {
        public static int Exercicio01(Operacoes op, int num1, int num2)
        {
            int result = 0;
            switch (op)
            {
                case Operacoes.Adicao:
                    result = num1 + num2;
                    break;
                case Operacoes.Multiplicacao:
                    return num1 * num2;
                    break;
                case Operacoes.Subtracao:
                    result = num1 - num2;
                    break;
                case Operacoes.Divisao:
                    result = num1 / num2;
                    break;
                default:
                    break;
            }
            return result;
        }

        public static int Exercicio02(int num1, int num2, int num3)
        {
            int result = num1 * num2 * num3;
            Console.WriteLine("o Volume é: {0} ", result);
            return result;
        }

        public static double Exercicio03(float alt, float raio)
        {
            double result = Math.PI * Math.Pow(raio, 2) * alt;
            Console.WriteLine("O volume do Cilindro é: ", result);
            return result;
        }

        public static double Exercicio04(float raio)
        {
            double result = (4 * Math.PI * Math.Pow(raio, 3) / 3);
            Console.WriteLine("O volume da esfera é: {0} ", result);
            return result;
        }
        
    }
}
