using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBusinessClassLibrary
{
    public class Customer
    {
        private int customerID;
        private string name;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string phone;
        private string email;

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string EMail
        {
            get { return email; }
            set { email = value; }
        }

        public Customer() { }
    }
}
