using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceUserModern2.View.ShoppingView;
using InterfaceUserModern2.Interface;

namespace InterfaceUserModern2.View
{
    public partial class Shopping : Form, IForm
    {
        private ListShopping listShopping;
        public Shopping()
        {
            this.listShopping = new ListShopping();
            InitializeComponent();
            this.OpenForms(this.listShopping);
        }

        public void enabledButtonEditOrList(bool etat, string type = null)
        {
            throw new NotImplementedException();
        }

        public void OpenForms(object form)
        {
            if (this.pnlShoppingContainer.Controls.Count > 0)
            {
                this.pnlShoppingContainer.Controls.RemoveAt(0);
            }

            Form fS = form as Form;
            fS.TopLevel = false;
            fS.Dock = DockStyle.Fill;
            this.pnlShoppingContainer.Controls.Add(fS);
            this.pnlShoppingContainer.Tag = fS;
            fS.Show();
        }
    }
}
