using Caso1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RestaurantJsonStructure restaurantData = new ComboDatabase().loadData();

            setMainDishes(restaurantData.MainDish);

        }

        private void setMainDishes(List<MainDish> mainDishes)
        {
            foreach(var dish in mainDishes)
            {
                cmbPlatosFuerte.Items.Add(dish.toString());
            }
        }


    }
}   
