using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercício2.Classes
{
    class Adulto : Pessoa
    {
        public Adulto()
        {
        }

        public Adulto(string nome, int idade) : base(nome, idade)
        {
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
