using RPG.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Batalhas;
using RPG.Inventario;
namespace RPG.Acoes

{
    public class MenuPrincipal:Luta1  
    {
        Lista p = new Lista();
        Assassino jogador1 = new Assassino();
        Luta1 j1 = new Luta1();

        public MenuPrincipal()
        {
            j1.Criacao();
            MainMenu();

        }
        public static int Menu()
        {
            Console.WriteLine("RGP.SIN------Menu de opção");
            Console.WriteLine("0 - Sair da Mochila ");
            Console.WriteLine("1 - Listar todos os itens ");
            Console.WriteLine("2 - Batalhar");
            Console.WriteLine("3 - Ver seus atributos ");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;

        }
        public void MainMenu()
        {
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                switch (resp)
                {
                    case 1:
                        p.ListarItens();
                        break;
                    case 2:
                        j1.Combat();
                        break;
                    case 3:
                        Console.WriteLine("Sobre sua classe:");
                        Console.WriteLine(jogador1.SobreaClasse());
                        Console.WriteLine("___________________________________________\n");
                        Console.WriteLine("Seu atributos são: ");
                        Console.WriteLine($"Você tem {jogador1.Vida} de vida ");

                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
