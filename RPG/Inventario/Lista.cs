using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventario
{
    public class Lista
    {
        public Lista()
        {
            this.IniciarLista();
        }
        private List<Bag> itens;

        public List<Bag> Itens
        {
            get { return itens; }
           
        }

        private void IniciarLista()
        {
            itens = new List<Bag>();
            Bag p = new Bag(10, 25);
            Itens.Add(p);

        }
        public void ListarItens()
        {
            for (int i = 0; i < Itens.Count; i++)
            {
                this.Itens[i].ExibirItens();
            }
        }
    }
}
