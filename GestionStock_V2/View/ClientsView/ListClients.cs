using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock_V2.View.ClientsView
{
    public partial class ListClients : Form
    {
        private int index;

        public ListClients()
        {
            InitializeComponent();
        }

        private void dataGridClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.index = e.RowIndex;
        }

        public int getIndex()
        {
            return this.index;
        }
    }
}
