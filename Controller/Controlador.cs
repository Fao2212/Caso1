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
    public class Controlador
    {
    
        ICombo comboActual;
        Form1 f;

        public void addToComboActual(string code)
        {
            comboActual.addComponent((IAddable)new ComponentPrototypeFactory().get(code));
         
        }

        public void build()
        {
            Combo comboTerminado = comboActual.agregar();
            f.showCombo(comboTerminado.toString());
            f.updateTotalOrden(comboTerminado.getPrice());
        }

        public void setComboActual(string comboName)
        {
            comboActual = new ComboPrototypeFactory().get(comboName);
            //System.Diagnostics.Debug.WriteLine(comboActual.toString());
        }

        public void setComboPersonalizado(string mainCode){
            comboActual = new Combo.ComboBuilder().setMainDish(mainCode);
        }

        public void addVista(Form1 form1)
        {
            this.f = form1;
        }
    }
}
