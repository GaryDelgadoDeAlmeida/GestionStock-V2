using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock_V2.View.ProductsView
{
    public partial class DeleteProducts : Form
    {
        public DeleteProducts()
        {
            InitializeComponent();
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(this.cmbDeleteProduct.Text != "-- Choisir le produit --")
            {
                MessageBox.Show(this.cmbDeleteProduct.Text.ToString());
            }
            else
            {
                MessageBox.Show("Veuillez choisir un produit à supprimer");
            }
        }
    }
}
