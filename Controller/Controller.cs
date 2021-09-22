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
        ComboBuilder comboActual = new ComboBuilder();


        public void addToComboActual(string code)
        {
            comboActual.addComponent((IAddable)new ComponentPrototypeFactory().get(code));
        }
    }
}
