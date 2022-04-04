using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystewm
{
    class Address
    {
        public string AddressBookName;
        public string FirstName;
        public string LastName;
        public string address;
        public string Email;
        public string PhoneNumber;
        public string State;
        public string Zip;
        public string Country;

        public Address(string addressbookname , string firstname, string lastname, string address, string email, string phonenumber, string state, string zip, string country)
        {
            this.AddressBookName = addressbookname;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.address = address;
            this.Email = email;
            this.PhoneNumber = phonenumber;
            this.State = state;
            this.Zip = zip; 
            this.Country = country;
        }
    }
}
