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
            this.insertClientData();
        }

        private void insertClientData()
        {
            this.dataGridClients.Rows.Insert(0, "1", "Garry", "Almeida", "0652073997", "gary.almeida.work@gmail.com", "189 rue vercingétorix", "75014", "Paris", "France");
            this.dataGridClients.Rows.Insert(1, "2", "Garry", "Almeida", "0652073997", "gary.almeida.work@gmail.com", "189 rue vercingétorix", "75014", "Paris", "France");
            this.dataGridClients.Rows.Insert(2, "3", "Garry", "Almeida", "0652073997", "gary.almeida.work@gmail.com", "189 rue vercingétorix", "75014", "Paris", "France");
            this.dataGridClients.Rows.Insert(3, "4", "Garry", "Almeida", "0652073997", "gary.almeida.work@gmail.com", "189 rue vercingétorix", "75014", "Paris", "France");
            this.dataGridClients.Rows.Insert(4, "5", "Garry", "Almeida", "0652073997", "gary.almeida.work@gmail.com", "189 rue vercingétorix", "75014", "Paris", "France");
            this.dataGridClients.Rows.Insert(5, "6", "Garry", "Almeida", "0652073997", "gary.almeida.work@gmail.com", "189 rue vercingétorix", "75014", "Paris", "France");
            this.dataGridClients.Rows.Insert(6, "7", "Garry", "Almeida", "0652073997", "gary.almeida.work@gmail.com", "189 rue vercingétorix", "75014", "Paris", "France");
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
