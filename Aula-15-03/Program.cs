using System;

namespace Aula_15_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Eduardo");
            Pessoa pessoa2 = pessoa;

            pessoa2 = new Pessoa("Saiury");

            Console.WriteLine($"{nameof(pessoa)}:" +
                $"{pessoa.Nome}");
            Console.WriteLine($"{nameof(pessoa2)}:" +
                $"{pessoa2.Nome}");


            Console.ReadLine();
        }
    }
}
