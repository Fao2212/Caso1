using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1.Model
{
    public class ComboJsonStructure
    {
        string name;
        double price;
        MainDish mainDish;
        List<string> components;

        public ComboJsonStructure(string name,MainDish mainDish, List<string> components, double price)
        {
            this.name = name;   
            this.mainDish = mainDish;
            this.components = components;
            this.price = price;
        }

        public Combo toCombo()
        {
            return new Combo(name, mainDish, components, price);
        }

        public string getName()
        {
            return name;
        }

        // Por mientras, para cargar datos en el FORM
        public string toString()
        {
            return toCombo().toString();
        }
    }
}
