using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                double numero1;
                double numero2;
                double resultado;
                string continuar = "sim";

                while (continuar == "sim")
                {

                    Console.WriteLine("Digite o primeiro número: ");
                    numero1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Operações: ");
                    Console.WriteLine("+ - Soma");
                    Console.WriteLine("- - Subtração");
                    Console.WriteLine("* - Multiplicação");
                    Console.WriteLine("/ - Divisão");

                    char operacao;

                    Console.WriteLine("Digite a operacao: ");
                    operacao = char.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número: ");
                    numero2 = double.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case '+':
                            resultado = numero1 + numero2;
                            Console.WriteLine("Soma: {0}", resultado);
                            break;
                        case '-':
                            resultado = numero1 - numero2;
                            Console.WriteLine("Subtração: {0}", resultado);
                            break;
                        case '*':
                            resultado = numero1 * numero2;
                            Console.WriteLine("Multiplicação: {0}", resultado);
                            break;
                        case '/':
                            resultado = numero1 / numero2;
                            Console.WriteLine("Divisão: {0}", resultado);
                            break;
                        default:
                            throw new Exception("Operação inválida!");
                            break;
                    }
                    Console.WriteLine("Deseja continuar calculando? (sim / nao) ");
                    continuar = Console.ReadLine();
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
