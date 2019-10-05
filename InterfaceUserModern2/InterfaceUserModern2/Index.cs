using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using InterfaceUserModern2.View;

namespace InterfaceUserModern2
{
    public partial class Index : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private Home formHome;

        public Index()
        {
            this.formHome = new Home();
            InitializeComponent();
            this.OpenForms(this.formHome);
        }

        /// <summary>
        /// Ferme ("Eteindre") l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Permet de mettre la fenêtre de l'application à la taille de l'écran hôte (ordinateur).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.picMaximize.Visible = false;
            this.picNormalize.Visible = true;
        }
        
        /// <summary>
        /// Permet de remettre la taille originelle de la fenêtre de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picNormalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.picMaximize.Visible = true;
            this.picNormalize.Visible = false;
        }

        /// <summary>
        /// Permet de minimisé (le même "cacher") la fenêtre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Permet de pouvoir déplacer la fenêtre de l'application elle-même.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        /// <summary>
        /// Régule la taille de l'espace de menu de l'application à des tailles définits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMenuBar_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu.Size.Width == 200)
            {
                this.pnlMenu.Size = new Size(45, this.pnlMenu.Size.Height);
                this.picHome.Size = new Size(40, 40);
                this.picHome.Location = new Point(3, 12);
                this.visibleStatusSocialLink(false);
            }
            else
            {
                this.pnlMenu.Size = new Size(200, this.pnlMenu.Size.Height);
                this.picHome.Size = new Size(180, 100);
                this.picHome.Location = new Point(13, 12);
                this.visibleStatusSocialLink(true);
            }
        }
        
        /// <summary>
        /// Ouvre le formulaire "Produit" dans le panel Container du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.OpenForms(new Products());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.OpenForms(new Sales());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.OpenForms(new Client());
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            this.OpenForms(new Shopping());
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            this.OpenForms(new Suppliers());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.OpenForms(new Employees());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            this.OpenForms(new Payments());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.OpenForms(new Reports());
        }

        private void PicHome_Click(object sender, EventArgs e)
        {
            this.OpenForms(this.formHome);
        }

        /// <summary>
        /// Ouvre une fenêtre du navigateur vers mon profil LinkedIn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/garry-almeida-7538b3175/");
        }

        /// <summary>
        /// Ouvre une fenêtre du navigateur vers mon espace GitHub.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GaryDelgadoDeAlmeida");
        }

        /// <summary>
        /// Ouvre une fenêtre du navigateur vers mon site portFolio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicPortFolio_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://gary-delgado-de-almeida.000webhostapp.com/");
        }

        /// <summary>
        /// Change le status de visibilité des liens sociaux.
        /// </summary>
        /// <param name="etat"></param>
        private void visibleStatusSocialLink(bool etat)
        {
            this.picGitHub.Visible = etat;
            this.picLinkedIn.Visible = etat;
            this.picPortFolio.Visible = etat;
        }
    }
}
