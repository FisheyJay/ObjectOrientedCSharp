using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer() // a constructor with no parameters is the default constructor
            : this(0)   // this is constructor chaining - the default constructor calls the parameterized constructor below with a default initial value         
        {
            //AddressList = new List<Address>();   <-- so instead of this duplicated code, use the chaining above
        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
            // this will initialize so it is not null at run time and wont give null value exception
            // lists are just null if not initialized unlike strings,
        }

        //public Address WorkAddress { get; set; }
        //public Address HomeAddress { get; set; }

        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }

        public static int InstanceCount { get; set; }

        // the backing field
        private string _lastname;

        public string LastName
        {
            // get accessor
            get
            {
                // Any code here
                return _lastname;
            }
            // set accessor
            set
            {
                // Any validation code here
                _lastname = value;
            }           
        }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        //public Address WorkAddress { get; set; }
        //public Address HomeAddress { get; set; }      // Instead of two separate addresses, let's make nicer with a list of addresses

        //public List<Address> AddressList { get; set; }

        // propg tab tab
        public int CustomerId { get; private set; }  // means only we can set in here

        public string FullName
        {
            get
            {
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        // Auto Implemented properties - so much shorter, backing field
        // (so we still have encapsulation) is hidden and behind the scenes
        // but... only for cases where no code is needed in the get or set block.
        // public string FirstName { get; set; }

        // snippets: public int MyProperty { get; set; }

        ///////////////////////////
        //                       //
        // SNIPPETS ARE AWESOME! //
        //                       //
        //     CTRL + K + X      //
        //                       //
        ///////////////////////////
    }
}
