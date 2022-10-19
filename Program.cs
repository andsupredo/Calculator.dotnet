using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Calculadora");
                Console.WriteLine("");
                Console.WriteLine("Selecione a operação desejada: ");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Fechar calculadora");
                try
                {
                    var select = short.Parse(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            soma();
                            break;
                        case 2:
                            subt();
                            break;
                        case 3:
                            multi();
                            break;
                        case 4:
                            div();
                            break;

                        case 0:
                            Console.WriteLine("Encerrando o programa");
                            System.Environment.Exit(0); break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Insira apenas números inteiros");
                    continue;
                }
            }
        }
        static void soma()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            Console.WriteLine();
            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        static void subt()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 - v2;
            Console.WriteLine();
            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        static void multi()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            Console.WriteLine();
            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        static void div()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            Console.WriteLine();
            Console.WriteLine("O resultado da soma é: " + resultado);
        }
    }

}