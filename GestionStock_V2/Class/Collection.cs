using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock_V2.Class
{
    public class Collection
    {
        private List<Client> lesClients;
        private List<Sale> lesVentes;
        private List<Product> lesProduits;
        private List<Supplier> lesSuppliers;
        private List<Shopping> lesShoppings;
        private List<Employee> lesEmployees;

        public Collection(
            List<Client> lesClients,
            List<Sale> lesVentes,
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


        public Collection()
        {
            this.lesClients = new List<Client>();
            this.lesVentes = new List<Sale>();
            this.lesProduits = new List<Product>();
            this.lesSuppliers = new List<Supplier>();
            this.lesShoppings = new List<Shopping>();
            this.lesEmployees = new List<Employee>();
        }

        public List<Client> getClients()
        {
            return this.lesClients;
        }

        public void setClients(List<Client> clients)
        {
            this.lesClients = clients;
        }

        public void addClients(string firstName,
            string lastName,
            string phoneNumber,
            string email,
            string address,
            string postalCode,
            string city,
            string country)
        {
            this.lesClients.Add(new Client(firstName, lastName, phoneNumber, email, address, postalCode, city, country));
        }

        public List<Sale> getSales()
        {
            return this.lesVentes;
        }

        public void setSales(List<Sale> sales)
        {
            this.lesVentes = sales;
        }

        public void addSales(Product product, Client client)
        {
            this.lesVentes.Add(new Sale(product, client));
        }

        public List<Product> getProducts()
        {
            return this.lesProduits;
        }

        public void setProducts()
        {
            // code ...
        }

        public void addProducts(string productName, string category, string description, double price, int stock)
        {
            this.lesProduits.Add(new Product(productName, category, description, price, stock));
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


        public void serializeData()
        {
            // Create file to save the data.
            FileStream fs = new FileStream("./ApplicationData.txt", FileMode.Create);

            // BinaryFormatter object will perform the serialization
            BinaryFormatter bf = new BinaryFormatter();

            // Serialize() method serializes the data to the file
            bf.Serialize(fs, this);

            // Close the file
            fs.Close();
        }


        public void deserializeData()
        {
            // Open file to read the data
            FileStream fs = new FileStream("./ApplicationData.txt", FileMode.Open);

            // BinaryFormatter object performs the deserialization
            BinaryFormatter bf = new BinaryFormatter();

            // Create the object to store the deserialized data
            /*this = (Collection)bf.Deserialize(fs);*/

            // Close the file
            fs.Close();
        }
    }
}
