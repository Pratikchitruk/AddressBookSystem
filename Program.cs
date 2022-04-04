using System;
using System.Collections.Generic;

namespace AddressBookSystewm
{
    //UC-1
    class AddressPrompt
    {
        
        AddressBook book;

        public AddressPrompt()
        {
            book = new AddressBook();
        }

        static void Main(string[] args)
        {
            string selection = "";
            AddressPrompt prompt = new AddressPrompt();

            prompt.displayMenu();
            while (!selection.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Selection: ");
                selection = Console.ReadLine();
                prompt.performAction(selection);
            }
        }

        void displayMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("A - Add an Address");
            Console.WriteLine("D - Delete an Address");
            Console.WriteLine("E - Edit an Address");
            Console.WriteLine("L - List All Addresses");
            Console.WriteLine("Q - Quit");
        }

        void performAction(string selection)
        {
            string addressbookname = " ";
            string firstname = "";
            string lastname = "";
            string address = "";
            string email = "";
            string phonenumber = " ";
            string state = "";
            string zip = " ";
            string country = "";
            
            
//UC-2,5,6
            switch (selection.ToUpper())
            {
                case "A":
                    Console.WriteLine("Enter name of address: ");
                    addressbookname = Console.ReadLine();

                    Console.WriteLine("Enter Name: ");
                    firstname = Console.ReadLine();
                    Console.WriteLine("Enter LastName: ");
                    lastname = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter Email: ");
                    email = Console.ReadLine();
                    Console.WriteLine("Enter PhoneNumber; ");
                    phonenumber = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    state = Console.ReadLine();
                    Console.WriteLine("Enter zip: ");
                    zip = Console.ReadLine();
                    Console.WriteLine("Enter country: ");
                    country = Console.ReadLine();
                    if (book.add(addressbookname, firstname, lastname, address, email, phonenumber, state, zip, country ))
                    {
                        Console.WriteLine("Address successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("An address is already on file for {0}.", firstname);
                    }
                    break;
                    //UC-4
                case "D":
                    Console.WriteLine("Enter Name to Delete: ");
                    firstname = Console.ReadLine();
                    if (book.remove(firstname))
                    {
                        Console.WriteLine("Address successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Address for {0} could not be found.", firstname);
                    }
                    break;
                case "L":
                    if (book.isEmpty())
                    {
                        Console.WriteLine("There are no entries.");
                    }
                    else
                    {
                        Console.WriteLine("Addresses:");
                        book.list((a) => Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6}", a.FirstName, a.LastName, a.Email, a.PhoneNumber, a.State, a.Zip, a.Country));
                    }
                    break;
                    //UC-3
                case "E":
                    Console.WriteLine("Enter Name to Edit: ");
                    firstname = Console.ReadLine();
                    Address addr = book.find(firstname);
                    if (addr == null)
                    {
                        Console.WriteLine("Address for {0} count not be found.", firstname);
                    }
                    else
                    {
                        Console.WriteLine("Enter new Address: ");
                        addr.address = Console.ReadLine();
                        Console.WriteLine("Address updated for {0}", firstname);
                    }
                    break;
            }
        }
    }
}
