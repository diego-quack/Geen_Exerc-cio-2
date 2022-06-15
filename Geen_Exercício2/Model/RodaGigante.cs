using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercício2.Classes
{
    class RodaGigante
    {
        private Gondola[] Gondolas = new Gondola[18];

        public RodaGigante()
        {
        }
        public void Status()
        {
            for (int i = 0; i < Gondolas.Length; i++)
            {
                if (Gondolas[i] != null)
                {
                    Console.WriteLine(Gondolas[i].ToString());
                }
                else
                {
                    Console.WriteLine((i + 1) + ": (Vazio)");
                }
            }
        }
        public void Embarcar(int posicao, Pessoa assento1, Pessoa assento2 = null)
        {
            int index = posicao - 1;

            if (index >= 0 && index < Gondolas.Length)
            {
                while(Gondolas[index] != null)
                {
                    if(index == Gondolas.Length - 1)
                    {
                        break;
                    }
                    index++;
                }
                if (Gondolas[index] == null)
                {
                    Gondola gondola = new Gondola(index + 1);
                    if (assento1.Idade > 11)
                    {
                        gondola.Assento1 = assento1;
                        if(assento2 != null)
                        {
                            if(assento2.Idade > 11)
                            {
                                gondola.Assento2 = assento2;
                            }
                            else
                            {
                                Crianca crianca = (Crianca)assento2;
                                if(crianca.Responsavel != null)
                                {
                                    if (assento1 == crianca.Responsavel)
                                    {
                                        gondola.Assento2 = assento2;
                                    }
                                    else
                                    {
                                        Console.WriteLine(assento2.Nome + " tem menos de 12 e não está com reponsável.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(assento2.Nome + " tem menos de 12 anos e está sozinho.");
                                }
                            }
                        }
                    }
                    else
                    {
                        Crianca crianca = (Crianca)assento1;
                        if(assento2 != null)
                        {
                            if(assento2 == crianca.Responsavel)
                            {
                                gondola.Assento1 = assento1;
                                gondola.Assento2 = assento2;
                            }
                            else
                            {
                                Console.WriteLine(assento1.Nome + " tem menos de 12 e não está com reponsável.");
                            }
                        }
                        else
                        {
                            Console.WriteLine(assento1.Nome + " tem menos de 12 anos e está sozinho.");
                        }
                    }
                    if(gondola.Assento1 != null || gondola.Assento2 != null)
                    {
                        Gondolas[index] = gondola;
                    }
                }
                else
                {
                    Console.WriteLine("Cheio");
                }
            }
            else
            {
                Console.WriteLine("Assento inválido.");
            }
        }
    }
}

