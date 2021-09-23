using Caso1.Model;
using Caso1.Controller;
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
        Controlador controlador;
        
        int indexMainDish = -1;
        int indexCombo;
        double totalOrden;
        double totalCocaCola;
        RestaurantJsonStructure restaurantData;
        //public Form1()
        public Form1(Controlador controlador)
        {
            this.controlador = controlador;
            InitializeComponent();
            this.restaurantData = new ComboDatabase().loadData();

            setMainDishes(restaurantData.MainDish);
            setDrinks(restaurantData.Drink);
            setAditionals(restaurantData.Additional);
            setCombos(restaurantData.ComboJsonStructure);

        }
        
        public void updateTotalOrden(double newPrice)
        {
            double price = double.Parse(lblTotalOrden.Text);
            price += newPrice;
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
            lblOrdenes.Text += comboText + "\n\n";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAdicionales_Click(object sender, EventArgs e)
        {

        }

        private void cmbCombos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbCombos.SelectedIndex;
            string name = restaurantData.ComboJsonStructure[index].getName();
            controlador.setComboActual(name);
            cmbPlatosFuerte.Text = "";
        }

        private void cmbPlatosFuerte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbPlatosFuerte.SelectedIndex;
            string codeMainDish = restaurantData.MainDish[index].getCode();
            controlador.setComboPersonalizado(codeMainDish);

            cmbCombos.Text = "";

            /*double priceRestar;
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
            lblTotalCombo.Text = totalOrden.ToString();*/
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
            controlador.build();
            lblCantidadAdicional.Text = "0";
            lblCantidadBebida.Text = "0";
            cmbAditional.Text = "";
            cmbBebidas.Text = "";
            cmbCombos.Text = "";
            cmbPlatosFuerte.Text = "";
            
        }

        private void btnBebidasMas_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(lblCantidadBebida.Text);
            lblCantidadBebida.Text = (cant + 1 ).ToString();
            int index = cmbBebidas.SelectedIndex;
            string codeName = restaurantData.Drink[index].getCode();
            controlador.addToComboActual(codeName);

        }

        private void pnlAdicionales_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAdicionalesMas_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(lblCantidadAdicional.Text);
            lblCantidadAdicional.Text = (cant + 1).ToString();
            int index = cmbAditional.SelectedIndex;
            string codeName = restaurantData.Additional[index].getCode();
            controlador.addToComboActual(codeName);
        }

        private void cmbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCantidadBebida.Text = "0";
            /*int index = cmbBebidas.SelectedIndex;
            string codeName = restaurantData.Drink[index].getCode();
            controlador.addToComboActual(codeName);*/
        }

        private void cmbAditional_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCantidadAdicional.Text = "0";
            /*int index = cmbAditional.SelectedIndex;
            string codeName = restaurantData.Additional[index].getCode();*/
            //controlador.addToComboActual(codeName);
        }
    }
}   
