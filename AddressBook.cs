using System.Collections.Generic;
using System.Collections;
using System;


namespace AddressBookCs
{
    public class AddressBook
    {
        public List <Contact> contacts = new List<Contact>();

        public void addContacs(Contact newcontact)
        {
            contacts.Add(newcontact);
        }
        public void listContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Id);
                Console.WriteLine(contact.Name);
                Console.WriteLine(contact.Cellphone);
                Console.WriteLine(contact.Email);
                Console.WriteLine("");
            };
        }
    }
}