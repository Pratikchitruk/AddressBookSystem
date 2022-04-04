using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystewm
{
    class AddressBook
    {
        List<Address> addresses;

        public AddressBook()
        {
            addresses = new List<Address>();
        }

        public bool add(string addressbookname, string firstname, string lastname, string address, string email, string phonenumber, string state, string zip, string country)
        {
            Address addr = new Address(addressbookname,firstname, address, lastname, email, phonenumber, state, zip, country);
            Address result = find(firstname);

            if (result == null)
            {
                addresses.Add(addr);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remove(string firstname)
        {
            Address addr = find(firstname);

            if (addr != null)
            {
                addresses.Remove(addr);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void list(Action<Address> action)
        {
            addresses.ForEach(action);
        }

        public bool isEmpty()
        {
            return (addresses.Count == 0);
        }

        public Address find(string firstname)
        {
            Address addr = addresses.Find((a) => a.FirstName == firstname);
            return addr;
        }
    }
}
