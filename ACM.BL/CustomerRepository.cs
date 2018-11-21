using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
                addressRepository = new AddressRepository();
        }

        // code that retrieves the desired customer
        public Customer Retrieve(int customerId)
        {
            // create the instance of the customer calss. customer
            Customer customer = new Customer(customerId);

            customer.AddressList = addressRepository.
                RetrieveByCustomerId(customerId).ToList();

            if (customerId == 1)
            {
                // Temp hard-coded values to return populated customer
                
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
