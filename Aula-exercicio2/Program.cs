using System;

namespace Aula_exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em dolares");

            string inputValue = Console.ReadLine();
            decimal parsedValue = 0.0m;
            decimal valueToMultiply = 5.22m;

            decimal.TryParse(inputValue, out parsedValue);
            decimal convertedValue = parsedValue * valueToMultiply;

            Console.WriteLine($"Valor em real: {convertedValue}");
            Console.ReadLine();
        }

    }
