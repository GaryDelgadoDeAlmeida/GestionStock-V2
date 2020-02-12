using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionStock_V2.Class;

namespace GestionStock_V2.View.ProductsView
{
    public partial class ListProducts : Form
    {
        public ListProducts()
        {
            InitializeComponent();
            insertProductData();
            this.dataGridListProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void insertProductData()
        {
            /*this.dataGridListProducts.Rows.Insert(0, "1", "G5 Gaming laptop", "Laptop", "Gaming laptop", "1500", "3");
            this.dataGridListProducts.Rows.Insert(1, "2", "Pomme", "Fruit", "Fruit d'une excelente richesse", "1.20", "10");
            this.dataGridListProducts.Rows.Insert(2, "3", "Café", "Plante", "Energise le buveur", "1.30", "20");
            this.dataGridListProducts.Rows.Insert(3, "4", "TV", "Electronique", "Reste informé des actualités", "120", "3");*/
        }
    }
}
