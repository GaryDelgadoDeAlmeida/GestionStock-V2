using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceUserModern2.View.ClientView;

namespace InterfaceUserModern2.View
{
    public partial class Client : Form
    {
        ListClient listClient;

        public Client()
        {
            InitializeComponent();
            listClient = new ListClient();
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
            this.OpenForms(new NewClient());
            this.btnListClient.Visible = true;
            this.btnEditClient.Visible = false;
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Row n° " + listClient.getIndex().ToString());
            this.btnListClient.Visible = true;
            this.btnEditClient.Visible = false;
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            this.btnListClient.Visible = true;
            this.btnEditClient.Visible = false;
        }

        private void btnListClient_Click(object sender, EventArgs e)
        {
            this.OpenForms(listClient);
            this.btnListClient.Visible = false;
            this.btnEditClient.Visible = true;
        }
    }
}
