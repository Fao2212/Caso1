 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caso1.Model;
using Caso1.Model.Factories;

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
            //Creacion de los Componentes
            Additional a1 = new Additional("atest","testAdicional",250);
            MainDish m1 = new MainDish("test","testMain",250);
            Drink d1 = new Drink("dtest","testD",250);

            //Todavia tengo que probar la parte estatica.

            new ComponentPrototypeFactory().save(a1);
            new ComponentPrototypeFactory().save(m1);
            new ComponentPrototypeFactory().save(d1);

            //Creacion de combos utilizando el ComponentPrototypeFactory solo acepta IAddable
            //Solo deberian poder agregarse componentes existentes definidos en el JSON
            Combo c1 = new Combo("Combo",(MainDish)new ComponentPrototypeFactory().get("test"),new Dictionary<String,Component>());
            c1.addComponent((IAddable) new ComponentPrototypeFactory().get("atest"));//Solo puedo agregar IAddable.
            System.Diagnostics.Debug.WriteLine(c1.toString());
            System.Diagnostics.Debug.WriteLine("End");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RestaurantJsonStructure restaurantData = new ComboDatabase().loadData();
            System.Diagnostics.Debug.WriteLine(restaurantData.MainDish[0].toString());
            

            Application.Run(new Form1());

        }
    }
}
