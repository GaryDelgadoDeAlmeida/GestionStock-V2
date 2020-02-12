using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionStock_V2.View.ClientsView;

namespace GestionStock_V2.View
{
    public partial class Clients : Form
    {
        ListClients listClient;

        public Clients()
        {
            InitializeComponent();
            listClient = new ListClients();
            this.OpenForms(listClient);
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

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            this.OpenForms(new NewClients());
            this.btnListClient.Enabled = true;
            this.btnEditClient.Enabled = false;
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Row n° " + listClient.getIndex().ToString());
            this.btnListClient.Enabled = true;
            this.btnEditClient.Enabled = false;
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            this.btnListClient.Enabled = true;
            this.btnEditClient.Enabled = false;
        }

        private void btnListClient_Click(object sender, EventArgs e)
        {
            this.OpenForms(listClient);
            this.btnListClient.Enabled = false;
            this.btnEditClient.Enabled = true;
        }
    }
}
