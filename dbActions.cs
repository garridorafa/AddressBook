using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AddressBookCs
{
    public class dbActions
    {
        MySqlController dbUsed = new MySqlController();
        public List <Contact> contactsReaded = new List<Contact>();
        public void read()
        {
            dbUsed.connect();
            MySqlCommand command = new MySqlCommand("SELECT * FROM contactslist;", dbUsed.conn);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    contactsReaded.Add(new Contact($"{reader["name"]}",$"{reader["cellphone"]}",$"{reader["email"]}"));
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