using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceUserModern2.View;

namespace InterfaceUserModern2.View.ProductsView
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text == "" || 
                this.txtCategory.Text == "" || 
                this.txtDescription.Text == "" || 
                this.txtPrice.Text == "" ||
                this.txtStock.Text == ""
                )
                MessageBox.Show("Input can't be empty.");
            else
                MessageBox.Show("The product " + this.txtName.Text + " was correctly added on the database");
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            this.txtName.Text = null;
            this.txtCategory.Text = null;
            this.txtDescription.Text = null;
            this.txtPrice.Text = null;
            this.txtStock.Text = null;
        }
    }
}
