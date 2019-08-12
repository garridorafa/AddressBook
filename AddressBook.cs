using System.Collections.Generic;
using System.Collections;
using System;


namespace AddressBookCs
{
    public class AddressBook
    {
        public List <Contact> contacts = new List<Contact>();
        public List <Contact> contactFound = new List<Contact>();

        public void addContacts(Contact newcontact)
        {
            contacts.Add(newcontact);
        }

        public void searchContact(string contactName)
        {
            contactFound.Clear();
            foreach (var contact in contacts)
            {
                if (contact.Name == contactName)
                {
                    contactFound.Add(contact);
                }
            };
        }

        public void deleteContact(string id)
        {
            contacts.RemoveAll(Contact => Contact.Id == id);
        }

        
    }
}