
using System.Collections.Generic;

namespace Caso1.Model.Factories
{
    public class ComboPrototypeFactory : IFactory<Combo>
    {

        static Dictionary<string, Component> combos = new Dictionary<string, Combo>();

        static ComboPrototypeFactory()
        {

        }

        public Component get(string comboCode)
        {
            return ComboPrototypeFactory.combos[comboCode];
        }

        public void save(Combo combo)
        {
            ComboPrototypeFactory.combos.Add(combo.getCode(), combo);
        }
    }
}