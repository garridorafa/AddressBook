using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AddressBookCs
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 

            // Connect to the database using a connection string
            MySqlConnection connection = new MySqlConnection {
                ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;port=3306;database=addressbook;SslMode=None"
            };
            connection.Open();
 
            // SELECT from database table
            MySqlCommand command = new MySqlCommand("SELECT * FROM contactslist;", connection);

            // Print the table (in this case my table had the fields "id" and "name"
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                System.Console.WriteLine("Id\t\tName");
                while (reader.Read())
                {
                    string row = $"{reader["id"]}\t\t{reader["name"]}";
                    System.Console.WriteLine(row);
                }
            }
            
            // Close the connection
            connection.Close();
            ///
            */
            MySqlController.connect();
            MySqlController.sqlExe();
            MySqlController.disconnect();

            //fin////////////////////////////////////////////////////
            Contact c1 = new Contact("1", "Rafa", "809-000-0001", "example1@mail.com");
            Contact c2 = new Contact("2", "Jhon", "809-000-0002", "example2@mail.com");
            Contact c3 = new Contact("3", "Rafa", "809-000-0003", "example3@mail.com");
            AddressBook ab = new AddressBook();
            ab.addContacts(c1);
            ab.addContacts(c2);
            ab.addContacts(c3);

            //ab.listContacts();
            //Console.WriteLine("Search Rafa");
            //ab.searchContact("Rafa");

            //Console.WriteLine("Deleting first Rafa");
            //ab.deleteContact("1");
            //ab.searchContact("Rafa");
            

            //Initializing CLI
            cli cli1 = new cli();
            cli1.addressBookUsed = ab;

            cli1.run();
            

        }
    }
}


