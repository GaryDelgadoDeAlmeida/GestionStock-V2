using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock_V2.Class
{
    public class Supplier : Person
    {
        private int quantity;
        private double price;
        private List<Product> products;

        public Supplier(
            string firstName,
            string lastName,
            string phoneNumber,
            string email,
            string address,
            string postalCode,
            string city,
            string country,
            int quantity,
            double price,
            List<Product> products) : base(firstName, lastName, phoneNumber, email, address, postalCode, city, country)
        {
            this.quantity = quantity;
            this.price = price;
            this.products = products;
        }


        public Supplier(
            string firstName,
            string lastName,
            string phoneNumber,
            string email,
            string address,
            string postalCode,
            string city,
            string country,
            int quantity,
            double price) : base(firstName, lastName, phoneNumber, email, address, postalCode, city, country)
        {
            this.quantity = quantity;
            this.price = price;
            this.products = new List<Product>();
        }


        /// <summary>
        /// Getter quantity
        /// </summary>
        /// <returns></returns>
        public int getQuantity()
        {
            return this.quantity;
        }


        /// <summary>
        /// Getter price
        /// </summary>
        /// <returns></returns>
        public double getPrice()
        {
            return this.price;
        }


        /// <summary>
        /// Récupére la liste des produits.
        /// </summary>
        /// <returns></returns>
        public List<Product> getProducts()
        {
            return this.products;
        }


        /// <summary>
        /// Mets à jour la liste des produits.
        /// </summary>
        /// <param name="products"></param>
        public void setProducts(List<Product> products)
        {
            this.products = products;
        }


        /// <summary>
        /// Ajout un produit dans la liste des produits.
        /// </summary>
        /// <param name="product"></param>
        public void addProduct(Product product)
        {
            if(!this.checkBeforeInsert(product))
            {
                this.products.Add(product);
            }
        }


        /// <summary>
        /// Ajout un produit dans la liste des produits.
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        public void addProduct(string productName, string category, string description, double price, int stock)
        {
            Product product = new Product(productName, category, description, price, stock);

            if(!this.checkBeforeInsert(product))
            {
                this.products.Add(product);
            }
        }


        /// <summary>
        /// Supprime un prpduit s'il existe dans la liste des produits.
        /// </summary>
        /// <param name="product"></param>
        public void deleteProduct(Product product)
        {
            if(this.products.Contains(product))
            {
                this.products.Remove(product);
            }
        }
        

        /// <summary>
        /// Vérifie l'existance d'un produit (par son nom) dans
        /// la liste des produits avant une possible inserssion
        /// dans la liste.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        private bool checkBeforeInsert(Product product)
        {
            bool check = false;

            foreach (Product item in this.products)
            {
                if (item.getProductName() != product.getProductName())
                {
                    check = true;
                    break;
                }
            }

            return check;
        }
    }
}
