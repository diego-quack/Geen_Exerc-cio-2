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

        public void Embarcar(int posicao, Pessoa crianca, Pessoa adulto)
        {
            List<String> lista = new List<String>();

            adulto = new Adulto();

            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");
            lista.Add("Vazio");

            if (crianca.Idade < 12 && adulto == null)
            {
                Console.WriteLine("ERRO: Não é permitido embarcar sem responsável");
            }
            if (crianca.Idade > 13 && adulto == null)
            {
                crianca = new Crianca(crianca.Nome, crianca.Idade);
                lista.Insert(posicao, crianca.Nome);
            }
            else
            {
                crianca = new Crianca(crianca.Nome, crianca.Idade, crianca.Responsavel);
                adulto = new Adulto(adulto.Nome, adulto.Idade);
                lista.Insert(posicao, crianca.Nome + crianca.Responsavel);
            }

            foreach (String ob in lista)
            {
                Console.WriteLine(ob);
            }

            public override string ToString()
        {
            return Numero + ", " +
        }
    }


}


