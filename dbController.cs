using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AddressBookCs
{
    public class MySqlController
    {
        public MySqlConnection conn;

        public void connect()
        {
            conn = new MySqlConnection {
                ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;port=3306;database=addressbook;SslMode=None"
            };
            conn.Open();
        }

        public void disconnect()
        {
            conn.Close();
        }

        public void sqlExe()
        {
            connect();
            MySqlCommand command = new MySqlCommand("SELECT * FROM contactslist;", conn);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                System.Console.WriteLine("Id\t\tName");
                while (reader.Read())
                {
                    string row = $"{reader["id"]}\t\t{reader["name"]}";
                    System.Console.WriteLine(row);
                }
            }
            disconnect();
        }
    }
}