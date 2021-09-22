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
        //Controller controlador;
        
        int indexMainDish = -1;
        int indexCombo;
        double totalOrden;
        double totalCocaCola;
        RestaurantJsonStructure restaurantData;
        public Form1(Controller controlador)
        public Form1()
        {
            InitializeComponent();
            this.restaurantData = new ComboDatabase().loadData();

            setMainDishes(restaurantData.MainDish);
        }

        private void setMainDishes(List<MainDish> mainDishes)
        {
            foreach(var dish in mainDishes)
            {
                cmbPlatosFuerte.Items.Add(dish.toString());
            }
        }

        public void showCombo(string comboText)
        {
            //Label.text()asdasdsad
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAdicionales_Click(object sender, EventArgs e)
        {

        }

        private void cmbCombos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPlatosFuerte_SelectedIndexChanged(object sender, EventArgs e)
        {
            double priceRestar;
            if (indexMainDish == -1)
            {
                priceRestar = 0;
            }
            else
            {
                priceRestar = getPrecioMainDish(indexMainDish);
            }

            indexMainDish = cmbPlatosFuerte.SelectedIndex;
            double price = getPrecioMainDish(indexMainDish);
            totalOrden += price - priceRestar;
            //lblTotal.Text = "¢ " + totalOrden.ToString();
        }

        private double getPrecioMainDish(int indexMainDish)
        {
            List<MainDish> mainDishes = this.restaurantData.MainDish;
            return mainDishes[indexMainDish].getPrice();
        }

        private void lblBebidas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}   
