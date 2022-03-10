using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            try
            {
                Console.WriteLine("Digite o seu nome: ");
                string nome = Console.ReadLine();

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
