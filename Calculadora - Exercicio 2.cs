using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    internal class Calculadora_Exercicio_2
    { 
        class ParametrosDeCalculo {
            public static int Somar(int a, int b) {
                return a + b;
            }

            public static int Subtrair(int a, int b) {
                return a - b;
            }
            
            public static int Multiplicar(int a, int b) {
                return a * b;
            }

            public static int Dividir(int a, int b) {
                return a / b;
            }
        }
        static void Main(string[] args) {
            string repetirAcao;

            // Inicio -----------------------------------------------------------------------

                Console.WriteLine("Ola! que calculos você gostaria de fazer?");

            do {
                // Armanezamentos dos valores para o calculo --------------------------------

                Console.Write("Digite o primeiro valor: ");
                int valor1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo valor: ");
                int valor2 = Convert.ToInt32(Console.ReadLine());

                // Escolha da opreção matemática que será feito -----------------------------

                Console.WriteLine("Selecione a Operação");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                int operacao = Convert.ToInt32(Console.ReadLine());
                int resultado = 0;

                switch (operacao) {
                    case 1:
                        resultado = ParametrosDeCalculo.Somar(valor1, valor2);
                        break;
                    case 2:
                        resultado = ParametrosDeCalculo.Subtrair(valor1, valor2);
                        break;
                    case 3:
                        resultado = ParametrosDeCalculo.Multiplicar(valor1, valor2);
                        break;
                    case 4:
                        resultado = ParametrosDeCalculo.Dividir(valor1, valor2);
                        break;
                    default:
                        Console.WriteLine("Ops.. Deu algo de errado.");
                        break;
                }

                // Resultado da Operação ----------------------------------------------------

                Console.WriteLine("O resultado é: " + resultado);

                // Loop para fazer outro calculo --------------------------------------------

                Console.WriteLine("Deseja fazer outro calculo?(S/N)");
                repetirAcao = Console.ReadLine();
            } while (repetirAcao.ToLower() == "s");
        }
    }
}
