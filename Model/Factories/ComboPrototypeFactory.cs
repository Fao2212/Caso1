
using System.Collections.Generic;

namespace Caso1.Model.Factories
{
    public class ComboPrototypeFactory : IFactory<Combo>
    {

        static Dictionary<string, Combo> combos = new Dictionary<string, Combo>();

        static ComboPrototypeFactory()
        {

        }

        public Combo get(string comboName)
        {
            return ComboPrototypeFactory.combos[comboName].deepClone();
        }

        public void save(Combo combo)
        {
            ComboPrototypeFactory.combos.Add(combo.getName(), combo);
        }
    }
}