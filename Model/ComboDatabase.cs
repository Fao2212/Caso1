using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings;
//using System.Text.Json.Serialization;
using System.IO;
//using System.Text.Json;
using Newtonsoft.Json;
using Caso1.Model.Factories;

namespace Caso1.Model
{
    
    class ComboDatabase
    {
        
        private static string _path = "data.json";


        public static string getDataFromJsonFile()
        {
            string data = File.ReadAllText(_path);
            return data;
        }
        


        public RestaurantJsonStructure loadData() 
        {
            string dataJson = getDataFromJsonFile();
            RestaurantJsonStructure restaurantData = JsonConvert.DeserializeObject<RestaurantJsonStructure>(dataJson);

            return restaurantData;


        }

        public void loadData(bool test)
        {
            string dataJson = getDataFromJsonFile();
            RestaurantJsonStructure restaurantData = JsonConvert.DeserializeObject<RestaurantJsonStructure>(dataJson);

            foreach (Component component in restaurantData.GetComponents())
            {
                new ComponentPrototypeFactory().save(component);
            }

            foreach(ComboJsonStructure combo in restaurantData.ComboJsonStructure)
            {
                new ComboPrototypeFactory().save(combo.toCombo());
            }

        }
    }
}
