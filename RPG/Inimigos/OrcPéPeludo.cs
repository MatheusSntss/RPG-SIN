using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inimigos
{
    public class OrcPéPeludo:Orc

    {
        public int[] Ataque = new int[6] { 1, 1, 2, 3, 4, 5, };
        public bool GamerOver()
        {
            if (vida < 1)
            {
                Console.WriteLine("Você morreu");
            }
            return Vivo = false;
        }
    }
}
