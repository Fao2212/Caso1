using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Caso1.Model
{
    class RestaurantJsonStructure
    {
        public List<Additional> Additional { get; set; }

        public List<Drink> Drink { get; set; }

        public List<MainDish> MainDish { get; set; }

        // Revisar el tema del diccionario y cargar el MainDish con sólo el código.
        public List<ComboJsonStructure> ComboJsonStructure { get; set; }


        public List<Component> GetComponents()
        {
            List<Component> components =  new List<Component>(Additional);
            components.Concat(Drink).Concat(MainDish);
            return components;
        }

    }
}
