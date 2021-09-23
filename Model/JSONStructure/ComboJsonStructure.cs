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

        public ComboJsonStructure(string name,MainDish mainDish, List<string> components)
        {
            this.name = name;   
            this.mainDish = mainDish;
            this.components = components;
        }

        public Combo toCombo()
        {
            return new Combo(name, mainDish, components, price);
        }

        // Por mientras, para cargar datos en el FORM
        public string toString()
        {
            string comboString = "Combo: " + this.name + "\n";
            comboString += " Main Dish: " + this.mainDish.toString() + this.price.ToString();
            return comboString;
        }
    }
}
