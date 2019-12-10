using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AddressBookCs
{
    public class dbActions
    {
        MySqlController dbUsed = new MySqlController();
        
        public void read()
        {
            dbUsed.connect();
            MySqlCommand command = new MySqlCommand("SELECT * FROM contactslist;", dbUsed.conn);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                System.Console.WriteLine("Id\tName\tCellphone\tEmail");
                while (reader.Read())
                {
                    string row = $"{reader["id"]}\t{reader["name"]}\t{reader["cellphone"]}\t\t{reader["email"]}";
                    System.Console.WriteLine(row);
                }
            }
            dbUsed.disconnect();
        }
        public void insert(string idToInsert, string nameToInsert, string cellphoneToInsert, string emailToInsert)
        {
            dbUsed.connect();
            MySqlCommand command = new MySqlCommand("INSERT INTO contactslist (Id, name, cellphone, email) VALUE ("+idToInsert+", '"+nameToInsert+"', '"+cellphoneToInsert+"', '"+emailToInsert+"')",dbUsed.conn);
            command.ExecuteNonQuery();
            dbUsed.disconnect();
        }
        public void delete(string idToDelete)
        {
            dbUsed.connect();
            MySqlCommand command = new MySqlCommand("DELETE FROM contactslist WHERE Id=" + idToDelete+";",dbUsed.conn);
            command.ExecuteNonQuery();
            dbUsed.disconnect();
        }
        public void update(string idToUpdate, string nameToUpdate, string cellphoneToUpdate, string emailToUpdate)
        {
            dbUsed.connect();
            MySqlCommand command = new MySqlCommand("UPDATE contactslist SET name='"+nameToUpdate+"', cellphone='"+cellphoneToUpdate+"', email='"+emailToUpdate+"' WHERE Id="+idToUpdate+";",dbUsed.conn);
            command.ExecuteNonQuery();
            dbUsed.disconnect();
        }
    }
}