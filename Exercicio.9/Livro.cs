using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio._9
{
    internal struct Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string Valor { get; private set; }

        public Livro(string titulo, string autor, string valor)
        {
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo);
            Autor = autor ?? throw new ArgumentNullException(nameof(autor);
            Valor = valor;
        }

        public override string ToString() 
            => $"Autor: {Autor} \n Titulo: {Titulo} \n Valor: {Valor}";
    }
}
