using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceUserModern2.View.ProductsView;

namespace InterfaceUserModern2.View
{
    public partial class Products : Form
    {
        private ListProduct ltPct;

        public Products()
        {
            InitializeComponent();
            ltPct = new ListProduct();
            this.OpenForms(ltPct);
        }

        // Ouvrir les formulaires
        private void OpenForms(object formS)
        {
            if (this.pnlContainer.Controls.Count > 0)
            {
                this.pnlContainer.Controls.RemoveAt(0);
            }

            Form fS = formS as Form;
            fS.TopLevel = false;
            fS.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(fS);
            this.pnlContainer.Tag = fS;
            fS.Show();
        }

        /// <summary>
        /// Ferme le formulaire "Products.cs"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.OpenForms(new AddProduct());
            this.btnProductList.Visible = true;
            this.btnEdit.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProduct etPct = new EditProduct();
            
            if (ltPct.dataGridListProducts.SelectedRows.Count > 0)
            {
                etPct.txtId.Text = ltPct.dataGridListProducts.CurrentRow.Cells[0].Value.ToString();
                etPct.txtProductName.Text = ltPct.dataGridListProducts.CurrentRow.Cells[1].Value.ToString();
                etPct.txtCategory.Text = ltPct.dataGridListProducts.CurrentRow.Cells[2].Value.ToString();
                etPct.txtDescription.Text = ltPct.dataGridListProducts.CurrentRow.Cells[3].Value.ToString();
                etPct.txtPrice.Text = ltPct.dataGridListProducts.CurrentRow.Cells[4].Value.ToString();
                etPct.txtStock.Text = ltPct.dataGridListProducts.CurrentRow.Cells[5].Value.ToString();
                this.OpenForms(etPct);
            }
            else
                MessageBox.Show("You need to select a row to edit a product.");
            this.btnEdit.Visible = false;
            this.btnProductList.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.OpenForms(new DeleteProduct());
            this.btnProductList.Visible = true;
            this.btnEdit.Visible = false;
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            this.OpenForms(ltPct);
            this.btnProductList.Visible = false;
            this.btnEdit.Visible = true;
        }
    }
}