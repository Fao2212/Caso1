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
        //public Form1(Controller controlador)
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

        private void lblBebidas_Click(object sender, EventArgs e)
        {

        }

        private void chkBoxCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCocaCola.Checked)
            {
                txtCocaCola.ReadOnly = false;
                txtCocaCola.Text = "1";
                
                totalCocaCola = getPrecioComponent(chkBoxChocolate.Text);
                totalOrden += totalCocaCola;
                lblPrecioCocaCola.Text = totalCocaCola.ToString();
            }
            else
            {
                txtCocaCola.Text = "0";
                txtCocaCola.ReadOnly = true;
                totalOrden -= totalCocaCola;
            }
            lblTotal.Text = "¢ " + totalOrden.ToString();
        }
        private double getPrecioComponent(string name)
        {
            var components = restaurantData.Components;
            foreach (var component in components)
            {
                if (component.getName() == name)
                {
                    return component.getPrice();
                }
            }
            return 0;
        }

        private void chkBoxTe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxTe.Checked)
            {
                txtTe.ReadOnly = false;
                txtTe.Text = "1";
            }
            else
            {
                txtTe.Text = "0";
                txtTe.ReadOnly = true;
            }
        }

        private void chkBoxCafe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCafe.Checked)
            {
                txtCafe.ReadOnly = false;
                txtCafe.Text = "1";
            }
            else
            {
                txtCafe.Text = "0";
                txtCafe.ReadOnly = true;
            }
        }

        private void chkBoxChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxChocolate.Checked)
            {
                txtChocolate.ReadOnly = false;
                txtChocolate.Text = "1";
            }
            else
            {
                txtChocolate.Text = "0";
                txtChocolate.ReadOnly = true;
            }
        }

        private void txtCocaCola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            /*else
            {
                double precioCocaCola = getPrecioComponent(chkBoxChocolate.Text);
                totalCocaCola = precioCocaCola * int.Parse(txtCocaCola.Text);
                totalOrden += totalCocaCola;
                lblTotal.Text = "¢ " + totalOrden.ToString();
            }*/
        }

        private void txtTe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCafe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtChocolate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void chkBoxTresLeches_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxTresLeches.Checked)
            {
                txtTresLeches.ReadOnly = false;
                txtTresLeches.Text = "1";
            }
            else
            {
                txtTresLeches.Text = "0";
                txtTresLeches.ReadOnly = true;
            }
        }

        private void chkBoxPapas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPapas.Checked)
            {
                txtPapas.ReadOnly = false;
                txtPapas.Text = "1";
            }
            else
            {
                txtPapas.Text = "0";
                txtPapas.ReadOnly = true;
            }
        }

        private void chkBoxEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxEnsalada.Checked)
            {
                txtEnsalada.ReadOnly = false;
                txtEnsalada.Text = "1";
            }
            else
            {
                txtEnsalada.Text = "0";
                txtEnsalada.ReadOnly = true;
            }
        }

        private void chkBoxPure_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPure.Checked)
            {
                txtPure.ReadOnly = false;
                txtPure.Text = "1";
            }
            else
            {
                txtPure.Text = "0";
                txtPure.ReadOnly = true;
            }
        }

        private void txtPapas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtTresLeches_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtEnsalada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            lblTotal.Text = "¢ "+ totalOrden.ToString();
        }

        private double getPrecioMainDish(int indexMainDish)
        {
            List<MainDish> mainDishes = this.restaurantData.MainDish;
            return mainDishes[indexMainDish].getPrice();
        }


        private void txtCocaCola_Leave(object sender, EventArgs e)
        {
            totalOrden -= totalCocaCola;
            string cant = txtCocaCola.Text;
            if (cant == "")
                cant = "0";
            if (cant != "0")
            {
                double precioCocaCola = getPrecioComponent(chkBoxChocolate.Text);
                totalCocaCola = precioCocaCola * int.Parse(cant);
                totalOrden += totalCocaCola;
                lblTotal.Text = "¢ " + totalOrden.ToString();
            }
        }
    }
}   
