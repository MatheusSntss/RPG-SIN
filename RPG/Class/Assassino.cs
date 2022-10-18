using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Class
{
    public class Assassino:Personagem
    {

        public int Vida=10;
        public int Energia=10;
        public int[] Ataque = new int[6] { 1,3,5,6,7,8 };
        public int fugir=4;
        public string SobreaClasse()
        {
            String texto;
            texto="Os assassin... Hã... Removedores são especialistas em venenos, disfarces e camuflagem. Usam essas técnicas com um único fim: aproximar-se de seu alvo e matá-lo. Alguns assas-sinos, mais honrados, " +
                "oferecem às suas vítimas uma chance de lutar e travam longos duelos; outros preferem eli-minar seus alvos de forma rápida e limpa, com uma flecha certeira ou veneno " +
                "fulminante. Outros ainda, movidos pela crueldade, fazem suas vítimas agonizar durante longas horas...";
            return texto;
        }
        public bool GamerOver()
        {
            if (Vida < 1)
            {
                Console.WriteLine("Você morreu");

                return Vivo = false;
            }
            return Vivo = false;
            
        }


    }
}
