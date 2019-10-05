using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceUserModern2.View.SuppliersView;

namespace InterfaceUserModern2.View
{
    public partial class Suppliers : Form
    {
        private ListSuppliers listSuppliers;

        public Suppliers()
        {
            this.listSuppliers = new ListSuppliers();
            InitializeComponent();
            this.OpenForms(this.listSuppliers);
        }

        /// <summary>
        /// Ouvrir les formulaires dans le panel container du formulaire
        /// </summary>
        /// <param name="formS"></param>
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


        private void enableButton(string buttonName, bool status = true)
        {
            if(status)
            {
                switch(buttonName)
                {
                    case "Edit":
                        this.btnEdit.Enabled = status;
                        this.btnList.Enabled = !status;
                        break;

                    case "List":
                        this.btnEdit.Enabled = !status;
                        this.btnList.Enabled = status;
                        break;
                }
            }
        }

        /// <summary>
        /// Ouvre l'interface d'ajout d'un vendeur dans le panel Container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.OpenForms(new AddSuppliers());
            this.enableButton("List");
        }

        /// <summary>
        /// Ouvre l'interface de modification des données d'un vendeur dans le panel Container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.OpenForms(new EditSuppliers());
            this.enableButton("List");
        }

        /// <summary>
        /// Ouvre l'interface de suppression d'un vendeur dans le panel Container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // code ...
        }

        /// <summary>
        /// Affiche la liste de tous les vendeurs répertoirié dans la base de données
        /// dans le panel Container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnList_Click(object sender, EventArgs e)
        {
            this.OpenForms(this.listSuppliers);
            this.enableButton("Edit");
        }
    }
}
