using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUserModern2.Class
{
    class Product
    {
        private int id = 0;
        private string productName;
        private string category;
        private string description;
        private double price;
        private int stock;

        public Product(string productName, string category, string description, double price, int stock)
        {
            this.id += 1;
            this.productName = productName;
            this.category = category;
            this.description = description;
            this.price = price;
            this.stock = stock;
        }


        public int getId()
        {
            return this.id;
        }


        /// <summary>
        /// Getter Product Name
        /// </summary>
        /// <returns></returns>
        public string getProductName()
        {
            return this.productName;
        }


        /// <summary>
        /// Setter Product Name
        /// </summary>
        /// <returns></returns>
        public void setProductName(string productName)
        {
            this.productName = productName;
        }


        /// <summary>
        /// Getter Category
        /// </summary>
        /// <returns></returns>
        public string getCategory()
        {
            return this.category;
        }


        /// <summary>
        /// Setter Category
        /// </summary>
        /// <returns></returns>
        public void setCategory(string category)
        {
            this.category = category;
        }


        /// <summary>
        /// Getter Description
        /// </summary>
        /// <returns></returns>
        public string getDescription()
        {
            return this.description;
        }


        /// <summary>
        /// Setter Description
        /// </summary>
        /// <param name="description"></param>
        public void setDescription(string description)
        {
            this.description = description;
        }


        /// <summary>
        /// Getter Price
        /// </summary>
        /// <returns></returns>
        public double getPrice()
        {
            return this.price;
        }


        /// <summary>
        /// Setter Price
        /// </summary>
        /// <param name="price"></param>
        public void setPrice(double price)
        {
            this.price = price;
        }


        /// <summary>
        /// Getter Stock
        /// </summary>
        /// <returns></returns>
        public int getStock()
        {
            return this.stock;
        }


        /// <summary>
        /// Setter Stock
        /// </summary>
        /// <param name="stock"></param>
        public void setStock(int stock)
        {
            this.stock = stock;
        }
    }
}
