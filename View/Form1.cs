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
        //public Form1()
        public Form1()
        {
            InitializeComponent();
            this.restaurantData = new ComboDatabase().loadData();

            setMainDishes(restaurantData.MainDish);
            setDrinks(restaurantData.Drink);
            setAditionals(restaurantData.Additional);
            setCombos(restaurantData.ComboJsonStructure);

        }

        public void updateTotalOrden(double price)
        {
            lblTotalOrden.Text = price.ToString();
        }

        private void setMainDishes(List<MainDish> mainDishes)
        {
            foreach(var dish in mainDishes)
            {
                cmbPlatosFuerte.Items.Add(dish.toString());
            }
        }

        private void setDrinks(List<Drink> drinks)
        {
            foreach (var drink in drinks)
            {
                cmbBebidas.Items.Add(drink.toString());
            }
        }

        private void setAditionals(List<Additional> aditionals)
        {
            foreach (var aditional in aditionals)
            {
                cmbAditional.Items.Add(aditional.toString());
            }
        }

        private void setCombos(List<ComboJsonStructure> combos)
        {
            foreach (var combo in combos)
            {
                cmbCombos.Items.Add(combo.toString());
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
            lblTotalCombo.Text = totalOrden.ToString();
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

        private void btnBebidasMas_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(lblCantidadBebida.Text);
            lblCantidadBebida.Text = (cant + 1 ).ToString();
        }

        private void btnBebidasMenos_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(lblCantidadBebida.Text);

            if (cant-1 > 0) { 
            
                lblCantidadBebida.Text = (cant + -1).ToString();
            }
            else
            {
                lblCantidadBebida.Text = "0";
                System.Diagnostics.Debug.WriteLine("Agregar método quitar del ");
            }
        }

        private void pnlAdicionales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionalesMenos_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(lblCantidadAdicional.Text);

            if (cant - 1 > 0)
            {

                lblCantidadAdicional.Text = (cant + -1).ToString();
            }
            else
            {
                lblCantidadAdicional.Text = "0";
                System.Diagnostics.Debug.WriteLine("Agregar método para quitar quitar del combo");
            }
        }

        private void btnAdicionalesMas_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(lblCantidadAdicional.Text);
            lblCantidadAdicional.Text = (cant + 1).ToString();
        }
    }
}   
