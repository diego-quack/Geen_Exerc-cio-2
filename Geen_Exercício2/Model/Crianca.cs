using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercício2.Classes
{
    class Crianca : Pessoa
    {
        public Adulto Responsavel { get; set; }

        public Crianca()
        {
        }

        public Crianca(string nome, int idade) : base(nome, idade)
        {
        }

        public Crianca(string nome, int idade, Adulto responsavel) : base(nome, idade)
        {
            Responsavel = responsavel;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
