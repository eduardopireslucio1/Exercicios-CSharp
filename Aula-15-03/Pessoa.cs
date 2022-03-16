using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_15_03
{
    class Pessoa
    {
        public string Nome { get; private set; }

        public Pessoa(string nome)
        {
            Nome = nome ??
                throw new ArgumentException(nameof(nome));
        }
    }
}
