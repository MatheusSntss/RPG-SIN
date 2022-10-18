using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventario
{
    public class Bag
    {

        public int Pocao { get; set; }
        public int Gold { get; set; }
        public Bag()
        {

        }
        public Bag(int pocao, int gold)
        {

            Pocao = pocao;
            Gold = gold;
        }
        public void ExibirItens()
        {

            Console.WriteLine($"{Pocao} Poção de cura");
            Console.WriteLine($"{Gold} de Gold");
        }



         

}
}
