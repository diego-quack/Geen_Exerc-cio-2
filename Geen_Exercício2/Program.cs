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

            roda.Embarcar(2, joao, maria);
            roda.Embarcar(2, joao, paulo);
            roda.Embarcar(3, maria);
            roda.Embarcar(13, pedro);
            roda.Embarcar(16, henrique);
            Console.WriteLine();
            roda.Status();
        }
    }
}
