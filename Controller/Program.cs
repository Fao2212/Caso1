 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caso1.Model;
using Caso1.Controller;
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
            /*Additional a1 = new Additional("atest","testAdicional",250);
            MainDish m1 = new MainDish("test","testMain",250);
            Drink d1 = new Drink("dtest","testD",250);
*/
            //Todavia tengo que probar la parte estatica.

           /* new ComponentPrototypeFactory().save(a1);
            new ComponentPrototypeFactory().save(m1);
            new ComponentPrototypeFactory().save(d1);
*/
            //Creacion de combos utilizando el ComponentPrototypeFactory solo acepta IAddable
            //Solo deberian poder agregarse componentes existentes definidos en el JSON
            //El prototype tiene que retornar un clon
            /*Combo c1 = new Combo("Combo",(MainDish)new ComponentPrototypeFactory().get("test"),new Dictionary<string,Component>());
            c1.addComponent((IAddable) new ComponentPrototypeFactory().get("atest"));//Solo puedo agregar IAddable.*/
            /*Combo c2 = new Combo.ComboBuilder().setName("Le combe").setMainDish((MainDish)new ComponentPrototypeFactory().get("test")).addComponent((IAddable)new ComponentPrototypeFactory().get("atest")).build();
            System.Diagnostics.Debug.WriteLine(c1.toString());
            System.Diagnostics.Debug.WriteLine(c2.toString());
            System.Diagnostics.Debug.WriteLine("End");*/

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //RestaurantJsonStructure restaurantData = new ComboDatabase().loadData();
            //System.Diagnostics.Debug.WriteLine(restaurantData.MainDish[0].toString());

            //Se pueden arreglar los metodos para que agrgar no sea tan feo
            new ComboDatabase().loadData(false);
            /*Combo c3 = new Combo.ComboBuilder().setName("Test2").setMainDish((MainDish)new ComponentPrototypeFactory().get("ham")).addComponent((IAddable)new ComponentPrototypeFactory().get("tleches")).build();
            System.Diagnostics.Debug.WriteLine(c3.toString());*/

            Controlador controlador = new Controlador();
            Form1 vista = new Form1(controlador);

            controlador.addVista(vista);
            Application.Run(vista);
        }
    }
}
