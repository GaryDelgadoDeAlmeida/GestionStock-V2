using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceUserModern2.View.EmployeesView;

namespace InterfaceUserModern2.View
{
    public partial class Employees : Form
    {
        private ListEmployees listEmployees;

        public Employees()
        {
            this.listEmployees = new ListEmployees();
            InitializeComponent();
            this.OpenForms(this.listEmployees);
        }

        // Ouvrir les formulaires
        private void OpenForms(object formS)
        {
            if (this.pnlEmployeesContainer.Controls.Count > 0)
            {
                this.pnlEmployeesContainer.Controls.RemoveAt(0);
            }

            Form fS = formS as Form;
            fS.TopLevel = false;
            fS.Dock = DockStyle.Fill;
            this.pnlEmployeesContainer.Controls.Add(fS);
            this.pnlEmployeesContainer.Tag = fS;
            fS.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="etat"></param>
        /// <param name="type"></param>
        private void enabledButtonEditOrList(bool etat, string type)
        {
            switch(type)
            {
                case "Edit":
                    if(etat)
                    {
                        this.btnEmployeesEdit.Enabled = etat;
                        this.btnEmployeesList.Enabled = !etat;
                    }
                    else
                    {
                        this.btnEmployeesEdit.Enabled = !etat;
                        this.btnEmployeesList.Enabled = etat;
                    }
                    break;

                case "List":
                    if (etat)
                    {
                        this.btnEmployeesEdit.Enabled = !etat;
                        this.btnEmployeesList.Enabled = etat;
                    }
                    else
                    {
                        this.btnEmployeesEdit.Enabled = etat;
                        this.btnEmployeesList.Enabled = !etat;
                    }
                    break;
            }
        }

        private void BtnEmployeesNew_Click(object sender, EventArgs e)
        {
            this.enabledButtonEditOrList(true, "List");
            this.OpenForms(new AddEmployees());
        }

        private void BtnEmployeesEdit_Click(object sender, EventArgs e)
        {
            this.enabledButtonEditOrList(true, "List");
            this.OpenForms(new EditEmployees());
        }

        private void BtnEmployeesDelete_Click(object sender, EventArgs e)
        {
            this.enabledButtonEditOrList(true, "List");
            this.OpenForms(new DeleteEmployees());
        }

        private void BtnEmployeesList_Click(object sender, EventArgs e)
        {
            this.OpenForms(this.listEmployees);
            this.enabledButtonEditOrList(true, "Edit");
        }
    }
}
