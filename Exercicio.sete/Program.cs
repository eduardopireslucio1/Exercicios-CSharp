using System;

namespace Exercicio.sete
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe seu nome:");
                var nome = Console.ReadLine();

                Console.WriteLine("Informe sua data de nascimento no formato dd/MM/yyyy:");
                //Passando por referência
                //DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);
                var dataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(ObterMensagemFaixaEtaria(nome, dataNascimento));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                Console.ReadLine();
            }
        }

        private static string ObterMensagemFaixaEtaria(string nome, DateTime dataNascimento)
        {
            var idade = DateTime.Today.Year - dataNascimento.Year;

            if (idade >= 60)
                return $"Olá {nome}, você está na faixa etária idoso!";
            else if (idade >= 20 && idade <= 79)
                return $"Olá {nome}, você está na faixa etária Adulto!";
            return $"Olá {nome}, você está na faixa etária Jovem!";


        }
    }
}
