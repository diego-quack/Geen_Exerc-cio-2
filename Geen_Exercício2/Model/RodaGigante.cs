using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercício2.Classes
{
    class RodaGigante
    {
        private List<Gondola> Gondolas = new List<Gondola>(18);

        public RodaGigante()
        {
            foreach (Gondola pessoa in Gondolas)
            {
                Console.WriteLine(pessoa + ": " + "(Vazio)");
            }
        }
        public void Embarcar2(int posicao, Crianca crianca, Adulto reponsavel)
        {
            Gondola gondola = new Gondola(posicao, crianca, reponsavel);
            Gondolas.Insert(posicao, gondola);
            Console.WriteLine(gondola);
        }
        public void Embarcar1(int posicao, Crianca crianca)
        {
            Gondola gondola = new Gondola(posicao, crianca);
            Gondolas[posicao] = gondola;
            Console.WriteLine(gondola);
        }
    }
}

