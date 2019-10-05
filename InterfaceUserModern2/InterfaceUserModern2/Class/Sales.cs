using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUserModern2.Class
{
    class Sales
    {
        private int id = 0;
        private Product product;
        private Client client;

        public Sales(Product product, Client client)
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
