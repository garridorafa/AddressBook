using System;
using System.Collections.Generic;

namespace AddressBookCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c1 = new Contact("1", "Rafa", "809-000-0001", "example1@mail.com");
            Contact c2 = new Contact("2", "Jhon", "809-000-0002", "example2@mail.com");
            Contact c3 = new Contact("3", "Rafa", "809-000-0003", "example3@mail.com");
            AddressBook ab = new AddressBook();
            ab.addContacs(c1);
            ab.addContacs(c2);
            ab.addContacs(c3);

            //ab.listContacts();
            Console.WriteLine("Search Rafa");
            ab.searchContact("Rafa");

            Console.WriteLine("Deleting first Rafa");
            ab.deleteContact("1");
            ab.searchContact("Rafa");
            

        }
    }
}
