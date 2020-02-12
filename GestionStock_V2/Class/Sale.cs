using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock_V2.Class
{
    public class Sale
    {
        private int id = 0;
        private Product product;
        private Client client;

        public Sale(Product product, Client client)
        {
            this.id += 1;
            this.product = product;
            this.client = client;
        }

        public Product getProduct()
        {
            return this.product;
        }

        public Client getClient()
        {
            return this.client;
        }
    }
}
