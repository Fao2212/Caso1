using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1.Model;
using static Caso1.Model.Combo;
using Caso1.Model.Factories;

namespace Caso1.Controller
{
    public class Controller
    {
        List<Combo> combos;
        ComboBuilder comboActual = new ComboBuilder();
        Form1 f = new Form1();
        

        public void addToComboActual(string code)
        {
            comboActual.addComponent((IAddable)new ComponentPrototypeFactory().get(code));
            updateTotal();
        }

        public void build()
        {
            Combo c = comboActual.build();
            //f.showCombo(c.toString());
        }

        public void updateTotal()
        {
            double precio = 0;
            foreach(var combo in combos){
                precio += combo.getPrice();
            }
            f.updateTotalOrden(precio);
            
        }
    }
}
