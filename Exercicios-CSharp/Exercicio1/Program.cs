using System;

namespace Aula_09_03
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Digite seu ano de nascimento: ");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Sua idade é:" + $"{DateTime.Today.Year - nascimento.Year} anos");
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
