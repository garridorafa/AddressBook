using System;
using System.Collections.Generic;

namespace AddressBookCs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook ab = new AddressBook();
            AddresBookCs.gui.screenVisual gui = new AddresBookCs.gui.screenVisual();
            gui.listOption();

            string actNumber = Console.ReadLine();
            

            ab.addContacs(new Contact("1", "Rafa", "789-453-1597", "example@mail.com"));
            ab.addContacs(new Contact("2", "Manuel", "789-453-1597", "example@mail.com"));
            ab.addContacs(new Contact("3", "Rocko", "789-453-1597", "example@mail.com"));

            switch (actNumber)
            {
                case "1":
                ab.listContacts();
                Console.ReadKey();
                gui.listOption();
                break;
                default:
                Console.WriteLine("Please enter a number...");
                break;
            }

        }
    }
}
