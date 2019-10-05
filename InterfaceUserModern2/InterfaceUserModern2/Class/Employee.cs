using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUserModern2.Class
{
    class Employee : Person
    {
        private string employee;

        public Employee(string firstName,
            string lastName,
            string phoneNumber,
            string email,
            string address,
            string postalCode,
            string city,
            string country,
            string employee) : base(firstName, lastName, phoneNumber, email, address, postalCode, city, country)
        {
            this.employee = employee;
        }

        public string getEmployee()
        {
            return this.employee;
        }

        public void setEmployee(string employee)
        {
            this.employee = employee;
        }
    }
}
