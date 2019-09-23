using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUserModern2.View.ClientView
{
    public partial class ListClient : Form
    {
        private int index;

        public ListClient()
        {
            InitializeComponent();
            this.insertClientData();
        }

        private void insertClientData()
        {
            this.dataGridClient.Rows.Insert(0, "1", "Garry", "Almeida", "189 rue vercingétorix", "Paris", "gary.almeida.work@gmail.com", "0652073997");
            this.dataGridClient.Rows.Insert(1, "2", "Garry", "Almeida", "189 rue vercingétorix", "Paris", "gary.almeida.work@gmail.com", "0652073997");
            this.dataGridClient.Rows.Insert(2, "3", "Garry", "Almeida", "189 rue vercingétorix", "Paris", "gary.almeida.work@gmail.com", "0652073997");
            this.dataGridClient.Rows.Insert(3, "4", "Garry", "Almeida", "189 rue vercingétorix", "Paris", "gary.almeida.work@gmail.com", "0652073997");
            this.dataGridClient.Rows.Insert(4, "5", "Garry", "Almeida", "189 rue vercingétorix", "Paris", "gary.almeida.work@gmail.com", "0652073997");
            this.dataGridClient.Rows.Insert(5, "6", "Garry", "Almeida", "189 rue vercingétorix", "Paris", "gary.almeida.work@gmail.com", "0652073997");
            this.dataGridClient.Rows.Insert(6, "7", "Garry", "Almeida", "189 rue vercingétorix", "Paris", "gary.almeida.work@gmail.com", "0652073997");
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
