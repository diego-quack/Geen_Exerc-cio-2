using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercício2.Classes
{
    class Gondola
    {
        public int Numero { get; set; }
        public Pessoa Assento1 { get; set; }
        public Pessoa Assento2 { get; set; }

        public Gondola()
        {
        }

        public Gondola(int numero, Pessoa assento1)
        {
            Numero = numero;
            Assento1 = assento1;
        }

        public Gondola(int numero, Pessoa assento1, Pessoa assento2) : this(numero, assento1)
        {
            Assento2 = assento2;
        }

        public override string ToString()
        {
            return Numero + ": " + Assento1.Nome + ", " + Assento2.Nome;
        }
    }
}


