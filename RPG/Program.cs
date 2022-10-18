using RPG.Class;
using RPG.Inimigos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Dados;
            
            
            OrcPéPeludo o1 = new OrcPéPeludo();
           Assassino j1 = new Assassino();
            Console.WriteLine("escolha seu nome: ");
            j1.Nome=Console.ReadLine();
            Console.WriteLine("seu nome é : " + j1.Nome);
            Console.WriteLine("Coloque 1 para ASSASSINO ou  2 p/ Guerreiro");
            int escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(escolha == 1)
            {
                Console.WriteLine("Você escolheu a classe assassino");
                Console.WriteLine("seu primeiro adversario sera um Orc pé peludo cujo o nome é " + o1.Nome);
                
                while ((j1.Vida>1) && (o1.vida>1))
                {
                   
                    Console.WriteLine("Aperte 1 para jogar os dados");
                    int jogar = Convert.ToInt32(Console.ReadLine());
                    if (jogar == 1) 
                    {
                        Dados = Random(1, 6);
                        Console.WriteLine("É a sua vez {0}", j1.Nome);
                        if (Dados > 1)
                        {
                            o1.vida = o1.vida - j1.Ataque[Dados];
                            Console.WriteLine("Orc levou um ataque e perdeu {0} de vida" , j1.Ataque[Dados]);
                        }

                        if (Dados > 1)
                        {
                            j1.Vida = j1.Vida - o1.Ataque[Dados];
                            Console.WriteLine("Don levou um ataque e perdeu {0} de vida", o1.Ataque[Dados]);
                        }
                    }


                    if (o1.vida<1)
                    {
                        Console.WriteLine(" ORC MORREU!!!!!");
                    }
                    else if (j1.Vida<1)
                    {
                        Console.WriteLine(  "DON MORREU !!!!");
                    }

                }
            }

            

            Console.ReadLine();
        }
        static int Random(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        static int Menu()
        {
            Console.WriteLine();
        }
    }
}
