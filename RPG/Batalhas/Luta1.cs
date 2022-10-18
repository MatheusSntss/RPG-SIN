using RPG.Class;
using RPG.Inimigos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Batalhas
{
    public class Luta1 : Assassino
    {

        Random random = new Random();
        string escolha; int Dados;
        int Contador = 1;
        Assassino j1 = new Assassino(); OrcPéPeludo o1 = new OrcPéPeludo();


        public void Combat()
        {
            Console.WriteLine("Escolha sua Classe,digitando o número equivalente a ela:");
            Console.Write("| Assassino - 1 | Mago - 2 | Arqueiro - 3 | Lanceiro = 4 | ");
            escolha = Console.ReadLine();
            if (escolha == "1")
            {
                Console.WriteLine("Seu nome é:{0} e sua classe é Assassino", j1.Nome);
                Console.WriteLine("seu primeiro adversario sera um Orc pé peludo");

                while ((j1.Vivo == true) && (o1.Vivo == true) && (j1.Fugiu == false))
                {
                    Console.WriteLine("________________{0}ª_RODADA_______________\n", Contador);
                    Dados = random.Next(1, 6);
                    if (j1.Turno == 1)
                    {
                        Console.WriteLine("Sua vez de jogar! Aperte (1)  para atacar ou  (2)  para tentar fugir");
                        escolha = Console.ReadLine();
                        switch (escolha)
                        {
                            case "1":
                                o1.vida = o1.vida - j1.Ataque[Dados];
                                Console.WriteLine("Você atacou o Orc causando {0} de vida", j1.Ataque[Dados]);
                                Console.WriteLine("-----------");
                                break;
                            case "2":
                                {
                                    if (Dados < j1.fugir) { Console.WriteLine("Você conseguiu fugir"); j1.Fugiu = true; }
                                    else { Console.WriteLine("Você falhou em fugir"); }
                                    break;
                                }
                                o1.Turno = 2;
                        }
                        if (o1.Turno == 2)
                        {
                            j1.Vida = j1.Vida - o1.Ataque[Dados];
                            Console.WriteLine("Você foi atacado e perdeu {0} de vida", o1.Ataque[Dados]);
                            Console.WriteLine("");
                            Console.WriteLine("Sua vida agora é: {0} ", j1.Vida);
                            j1.Turno = 1;
                        }
                        if (j1.Vida < 1)
                        {
                            Console.WriteLine("Você morreu");
                            j1.Vivo = false;
                        }
                        else if (o1.vida < 1)
                        {
                            Console.WriteLine("você ganhou");
                            o1.Vivo = false;
                        }
                        Contador++;
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}