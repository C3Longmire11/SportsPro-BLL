using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsProDataAccessClassLibrary;


namespace SportsProBusinessClassLibrary
{
    public class CustomerBL
    {
        CustomerDA customerDA = new CustomerDA();

        public CustomerBL() { }
        public List<Customer> GetAllCustomers()
        {
            ArrayList dataBaseRecords = new ArrayList();
            List<Customer> customerRecords = new List<Customer>();

            try
            {
                dataBaseRecords = customerDA.RetrieveAllCustomers();
                foreach (object[] arrayListRow in dataBaseRecords)
                {
                    Customer customerData = new Customer();
                    customerData.CustomerID = Convert.ToInt32(arrayListRow[0]);
                    customerData.Name = Convert.ToString(arrayListRow[1]);
                    customerData.Address = Convert.ToString(arrayListRow[2]);
                    customerData.City = Convert.ToString(arrayListRow[3]);
                    customerData.State = Convert.ToString(arrayListRow[4]);
                    customerData.ZipCode = Convert.ToString(arrayListRow[5]);
                    customerData.Phone = Convert.ToString(arrayListRow[6]);
                    customerData.EMail = Convert.ToString(arrayListRow[7]);
                    customerRecords.Add(customerData);
                }

                return customerRecords;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }

        public Customer GetCustomerByID(Int32 customerID)
        {

            object[] customerRecord = new object[8];
            Customer customerData = new Customer();

            try
            {
                customerRecord = customerDA.RetrieveCustomerByID(customerID);
                if (customerRecord != null)
                {
                    customerData.CustomerID = Convert.ToInt32(customerRecord[0]);
                    customerData.Name = Convert.ToString(customerRecord[1]);
                    customerData.Address = Convert.ToString(customerRecord[2]);
                    customerData.City = Convert.ToString(customerRecord[3]);
                    customerData.State = Convert.ToString(customerRecord[4]);
                    customerData.ZipCode = Convert.ToString(customerRecord[5]);
                    customerData.Phone = Convert.ToString(customerRecord[6]);
                    customerData.EMail = Convert.ToString(customerRecord[7]);

                    return customerData;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }

        public bool RemoveCustomer(Int32 customerID)
        {
            try
            {
                Int32 numberOfRecordsDeleted = customerDA.DeleteCustomer(customerID);

                if (numberOfRecordsDeleted == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public Int32 AddCustomer(Customer newCustomer)
        {
            try
            {
                Object[] aCustomer = new object[7];

                aCustomer[0] = newCustomer.Name;
                aCustomer[1] = newCustomer.Address;
                aCustomer[2] = newCustomer.City;
                aCustomer[3] = newCustomer.State;
                aCustomer[4] = newCustomer.ZipCode;
                aCustomer[5] = newCustomer.Phone;
                aCustomer[6] = newCustomer.EMail;
                Int32 newCustomerID = customerDA.InsertCustomer(aCustomer);
                return newCustomerID;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
    }
}
