using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock_V2.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void HourDate_Tick(object sender, EventArgs e)
        {
            this.txtHour.Text = DateTime.Now.ToLongTimeString();
            this.txtDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
