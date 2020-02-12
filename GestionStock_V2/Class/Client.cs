using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock_V2.Class
{
    public class Client : Person
    {
        public Client(
            string firstName,
            string lastName,
            string phoneNumber,
            string email,
            string address,
            string postalCode,
            string city,
            string country) : base (firstName, lastName, phoneNumber, email, address, postalCode, city, country)
        {
            
        }
    }
}
