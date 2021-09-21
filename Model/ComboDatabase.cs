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


namespace Caso1.Model
{
    
    class ComboDatabase
    {
        // Cambiar la ubicación del Json para no tener que poner la ruta. 
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

    }
}
