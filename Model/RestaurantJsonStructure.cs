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
        public List<Component> Components { get; set; }

        //public List<Component> Drink { get; set; }

        public List<MainDish> MainDish { get; set; }

        // Revisar el tema del diccionario y cargar el MainDish con sólo el código.
        public List<Combo> Combos { get; set; }
    }
}
