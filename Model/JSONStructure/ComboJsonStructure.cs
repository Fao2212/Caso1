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
            return new Combo(name, mainDish, components);
        }
    }
}
