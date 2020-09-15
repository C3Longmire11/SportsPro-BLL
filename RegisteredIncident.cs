using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBusinessClassLibrary
{
    public class RegisteredIncident
    {
        private int customerID;
        private string customerName;
        private DateTime? dateOpened;
        private DateTime? dateClosed;
        private string productName;
        private decimal version;
        private string techName;
        private string techEmail;
        private string techPhone;
        private string state;



        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }



        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }


        public DateTime? DateOpened
        {
            get { return dateOpened; }
            set { dateOpened = value; }
        }


        public DateTime? DateClosed
        {
            get
            { return dateClosed;}
            set { dateClosed = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }


        public decimal Version
        {
            get { return version; }
            set { version = value; }
        }


        public string TechName
        {
            get { return techName; }
            set { techName = value; }
        }


        public string TechEmail
        {
            get { return techEmail; }
            set { techEmail = value; }
        }


        public string TechPhone
        {
            get { return techPhone; }
            set { techPhone = value; }
        }



        public string State
        {
            get { return state; }
            set { state = value; }
        }

    }
}
