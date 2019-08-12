using System;

namespace AddressBookCs
{
    public class cli
    {
        public AddressBook addressBookUsed;

        public void run()
        {
            printOptions();
            string appAction = Console.ReadLine();
            actionsController(appAction);
        }
        
        public void printOptions()
        {
            Console.WriteLine("\n"+"--------------------------");
            Console.WriteLine("    COMMANDS OPTIONS");
            Console.WriteLine("--------------------------");
            Console.WriteLine(" 1. List all contacs");
            Console.WriteLine(" 2. Search contacs");
            Console.WriteLine(" 3. Add contac");
            Console.WriteLine(" 4. Remove contac");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("--------------------------");
        }

        public void printContact(Contact contact)
        
        {
            Console.WriteLine(contact.Id);
            Console.WriteLine(contact.Name);
            Console.WriteLine(contact.Cellphone);
            Console.WriteLine(contact.Email);
            Console.WriteLine("");
        }

        public void actionsController(string appAction)
        {
            switch (appAction)
            {
                case "1":
                    Console.WriteLine("Contacts List");
                    Console.WriteLine("--------------------------");
                    foreach (var contact in addressBookUsed.contacts)
                    {
                        printContact(contact);
                    };
                    Console.WriteLine("--------------------------");
                    Console.ReadKey();
                    run();
                    break;

                case "2":
                    Console.WriteLine("Enter the name:");
                    string cs = Console.ReadLine();
                    Console.WriteLine("Contacts List ---> "+cs);
                    Console.WriteLine("--------------------------");
                    addressBookUsed.searchContact(cs);
                    
                    if (addressBookUsed.contactFound.Count == 0)
                    {
                        Console.WriteLine("No Macths");
                    }else
                    {
                        foreach (var contact in addressBookUsed.contactFound)
                        {
                            printContact(contact);
                        };
                    }
                    Console.WriteLine("--------------------------");
                    Console.ReadKey();
                    run();
                    break;

                    case "3":
                    Console.WriteLine("Enter the id:");
                    string contacId = Console.ReadLine();
                    Console.WriteLine("Enter the Name:");
                    string contacName = Console.ReadLine();
                    Console.WriteLine("Enter the Cellphone:");
                    string contacCellphone = Console.ReadLine();
                    Console.WriteLine("Enter the Email:");
                    string contacEmail = Console.ReadLine();

                    addressBookUsed.addContacts(new Contact (contacId,contacName,contacCellphone,contacEmail));

                    Console.WriteLine("Complete!");
                    Console.ReadKey();
                    run();
                    break;

                    case "4":
                    Console.WriteLine("Insert contacts ID to delete:");
                    string contactId = Console.ReadLine();
                    addressBookUsed.deleteContact(contactId);
                    Console.ReadKey();
                    run();
                    break;

                case "0":
                    Console.WriteLine("See ya!");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Please press a elegible option.");
                    Console.ReadKey();
                    run();
                    break;
            }
        }
    }
}