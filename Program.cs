using System;
using System.Collections.Generic;

namespace AddressBookCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c1 = new Contact("1", "Rafa", "809-000-0000", "example@mail.com");
            Contact c2 = new Contact("2", "Jhon", "809-000-0000", "example@mail.com");
            AddressBook ab = new AddressBook();
            ab.addContacs(c1);
            ab.addContacs(c2);

            ab.listContacts();

        }
    }
}
