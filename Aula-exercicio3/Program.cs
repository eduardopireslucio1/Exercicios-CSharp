using System;

namespace Aula_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            IntConverter converter = new IntConverter();

            Console.WriteLine("Informe a distancia percorrida");
            string inputDistance = Console.ReadLine();

            Console.WriteLine("Informe o consumo de combustivel em litros");
            string inputFuel = Console.ReadLine();

            Int64 parsedDistance = converter.parseStringToInt(inputDistance);
            Int64 parsedFuel = converter.parseStringToInt(inputFuel);

            Int64 result = parsedDistance / parsedFuel;

            Console.WriteLine($" O consumo foi de {result} /L por KM");

        }
    }
