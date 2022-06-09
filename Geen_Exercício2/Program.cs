using Geen_Exercício2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            RodaGigante roda = new RodaGigante();

            Adulto paulo = new Adulto("Paulo", 42);
            Crianca joao = new Crianca("João", 5, paulo);
            Crianca maria = new Crianca("Maria", 12, paulo);
            Crianca pedro = new Crianca("Pedro", 13);
            Crianca henrique = new Crianca("Henrique", 10);

            roda.Embarcar2(2, pedro, paulo);
        }
    }
}
