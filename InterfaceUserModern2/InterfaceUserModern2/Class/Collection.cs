using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUserModern2.Class
{
    class Collection
    {
        private List<Client> lesClients;
        private List<Sales> lesVentes;
        private List<Product> lesProduits;
        private List<Supplier> lesSuppliers;
        private List<Shopping> lesShoppings;
        private List<Employee> lesEmployees;

        public Collection(
            List<Client> lesClients,
            List<Sales> lesVentes,
            List<Product> lesProduits,
            List<Supplier> lesSuppliers,
            List<Shopping> lesShoppings,
            List<Employee> lesEmployees)
        {
            this.lesClients = lesClients;
            this.lesVentes = lesVentes;
            this.lesProduits = lesProduits;
            this.lesSuppliers = lesSuppliers;
            this.lesShoppings = lesShoppings;
            this.lesEmployees = lesEmployees;
        }

        public List<Client> getClients()
        {
            return this.lesClients;
        }

        public List<Sales> getSales()
        {
            return this.lesVentes;
        }

        public List<Product> getProducts()
        {
            return this.lesProduits;
        }

        public List<Supplier> getSuppliers()
        {
            return this.lesSuppliers;
        }

        public List<Shopping> getShoppings()
        {
            return this.lesShoppings;
        }

        public List<Employee> getEmployees()
        {
            return this.lesEmployees;
        }
    }
}
