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
    public partial class DeleteEmployees : Form
    {
        public DeleteEmployees()
        {
            InitializeComponent();
            this.cmbDeleteEmployee.Text = "-- Choisissez l'employé --";
        }
    }
}