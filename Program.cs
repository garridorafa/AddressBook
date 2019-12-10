using System;
using System.Collections.Generic;

namespace AddressBookCs
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Contact c1 = new Contact("1", "Rafa", "809-000-0001", "example1@mail.com");
            Contact c2 = new Contact("2", "Jhon", "809-000-0002", "example2@mail.com");
            Contact c3 = new Contact("3", "Rafa", "809-000-0003", "example3@mail.com");
=======
            
            
            //Create new addressBook
>>>>>>> 96b2e31... Add database CRUD
            AddressBook ab = new AddressBook();
            
            cli cli1 = new cli();
            cli1.addressBookUsed = ab;
            dbActions db1 = new dbActions();

            //db1.listAll();
            cli1.addressBookUsed.listContacts();
            //cli1.addressBookUsed.addContacts((new Contact("1","Rafa", "829-000-0000","rafa@example.com")));
            //cli1.addressBookUsed.addContacts((new Contact("2","Jhon", "829-000-0000","jhon@example.com")));
            //cli1.addressBookUsed.addContacts((new Contact("3","Loise", "829-000-0000","loise@example.com")));
            cli1.addressBookUsed.modify("2",new Contact("3","prito", "829-000-0000","rafa.com"));
            cli1.addressBookUsed.listContacts();
            

<<<<<<< HEAD
            cli1.run();
=======
            //Initializing CLI
            //cli1.run();
            
            
>>>>>>> 96b2e31... Add database CRUD

        }
    }
}
