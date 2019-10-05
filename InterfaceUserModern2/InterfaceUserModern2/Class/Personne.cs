using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUserModern2.Class
{
    abstract class Person
    {
        protected int id = 0;
        protected string firstName;
        protected string lastName;
        protected string phoneNumber;
        protected string email;
        protected string address;
        protected string postalCode;
        protected string city;
        protected string country;

        public Person(
            string firstName, 
            string lastName, 
            string phoneNumber, 
            string email, 
            string address, 
            string postalCode, 
            string city,
            string country)
        {
            this.id += 1;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.postalCode = postalCode;
            this.city = city;
            this.country = country;
        }


        public int getId()
        {
            return this.id;
        }


        /// <summary>
        /// Getter First Name
        /// </summary>
        /// <returns></returns>
        public string getFirstName()
        {
            return this.firstName;
        }


        /// <summary>
        /// Setter First Name
        /// </summary>
        /// <param name="firstName"></param>
        public void setFistName(string firstName)
        {
            this.firstName = firstName;
        }


        /// <summary>
        /// Getter Last Name
        /// </summary>
        /// <returns></returns>
        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getPostalCode()
        {
            return this.postalCode;
        }

        public void setPostalCode(string postalCode)
        {
            this.postalCode = postalCode;
        }

        public string getCity()
        {
            return this.city;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public string getCountry()
        {
            return this.country;
        }

        public void setCountry(string country)
        {
            this.country = country;
        }
    }
}
