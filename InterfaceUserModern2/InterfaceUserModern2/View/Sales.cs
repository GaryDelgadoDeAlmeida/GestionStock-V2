using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceUserModern2.View.SalesView;

namespace InterfaceUserModern2.View
{
    public partial class Sales : Form
    {
        private ListSales listSales;
        public Sales()
        {
            this.listSales = new ListSales();
            InitializeComponent();
            this.OpenForms(this.listSales);
        }

        private void BtnAddSales_Click(object sender, EventArgs e)
        {
            // code ...
            this.OpenForms(new AddSales());
            this.enabledButtonEditOrList(true, "List");
        }

        private void BtnEditSales_Click(object sender, EventArgs e)
        {
            // code ...
            this.OpenForms(new EditSales());
            this.enabledButtonEditOrList(true, "List");
        }

        private void BtnDeleteSales_Click(object sender, EventArgs e)
        {
            // code ...
            this.OpenForms(new DeleteSales());
            this.enabledButtonEditOrList(true, "List");
        }

        private void BtnListSales_Click(object sender, EventArgs e)
        {
            // code ...
            this.OpenForms(this.listSales);
            this.enabledButtonEditOrList(true, "Edit");
        }


        /// <summary>
        /// Ouvre les formulaires dans le panel container
        /// de ce formulaire
        /// </summary>
        /// <param name="formS"></param>
        private void OpenForms(object formS)
        {
            if (this.pnlSalesContainer.Controls.Count > 0)
            {
                this.pnlSalesContainer.Controls.RemoveAt(0);
            }

            Form fS = formS as Form;
            fS.TopLevel = false;
            fS.Dock = DockStyle.Fill;
            this.pnlSalesContainer.Controls.Add(fS);
            this.pnlSalesContainer.Tag = fS;
            fS.Show();
        }


        /// <summary>
        /// Active ou désactive le control d'un button en fonction de l'etat
        /// </summary>
        /// <param name="etat"></param>
        /// <param name="type"></param>
        private void enabledButtonEditOrList(bool etat, string type = null)
        {
            switch (type)
            {
                case "Edit":
                    if (etat)
                    {
                        this.btnEditSales.Enabled = etat;
                        this.btnListSales.Enabled = !etat;
                    }
                    break;

                case "List":
                    if (etat)
                    {
                        this.btnEditSales.Enabled = !etat;
                        this.btnListSales.Enabled = etat;
                    }
                    break;

                default:
                    MessageBox.Show("Le button " + type + " n'existe pas. Il est impossible de changer son état.");
                    break;
            }
        }
    }
}
