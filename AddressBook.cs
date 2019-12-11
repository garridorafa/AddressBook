using System.Collections.Generic;
using System.Collections;
using System;


namespace AddressBookCs
{
    public class AddressBook
    {
        public List <Contact> contacts = new List<Contact>();
        public List <Contact> contactFound = new List<Contact>();
        dbActions dbcrud = new dbActions();

        public void listContacts ()
        {
            dbcrud.read();
            contacts = dbcrud.contactsReaded;
        }
        public void addContacts(Contact newcontact)
        {
            dbcrud.insert(newcontact.Name, newcontact.Cellphone, newcontact.Email);
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
            dbcrud.delete(id);
        }
        public void modify(string id, Contact newcontact)
        {
            dbcrud.update(id, newcontact.Name, newcontact.Cellphone, newcontact.Email);
        }
        
    }
}