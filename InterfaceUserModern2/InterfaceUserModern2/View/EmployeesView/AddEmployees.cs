﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUserModern2.View.EmployeesView
{
    public partial class AddEmployees : Form
    {
        public AddEmployees()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // code ...
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            // code ...
            this.txtLastName.Clear();
            this.txtFirstName.Clear();
            this.txtAddress.Clear();
            this.txtPhoneNumber.Clear();
            this.txtEmail.Clear();
            this.txtEmployee.Clear();
        }
    }
}
