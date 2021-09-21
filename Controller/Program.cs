 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caso1.Model;

namespace Caso1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Combo c1 = new Combo("Combo",new MainDish(),new Dictionary<String,List<Component>>());
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RestaurantJsonStructure restaurantData = new ComboDatabase().loadData();
            System.Diagnostics.Debug.WriteLine(restaurantData.MainDish[0].toString());
            

            Application.Run(new Form1());
        }
    }
}
