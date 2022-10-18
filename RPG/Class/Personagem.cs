using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Class
{
    public  class Personagem
    {
        public bool Fugiu = false;
        public string Nome;
        public bool Vivo = true;
        public int Turno = 1;
        public string _Classe = "";
        public void Criacao()
        {
            Console.Write("Digite o seu nome : ");
            Nome = Console.ReadLine();
        }

    }
}
