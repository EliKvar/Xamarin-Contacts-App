using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using System.Linq;

namespace ContactsApp.Models
{
    public class ContactsDB
    {
        private SQLiteConnection _connection;

        public ContactsDB()
        {
            _connection = DependencyService.Get<ISQLite>().GetConnection();
            _connection.CreateTable<Contact>();
        }
        public IEnumerable<Contact> GetContacts()
        {
            return _connection.Query<Contact>("Select * From Contact Order by ID");

        }
        public Contact GetContact(int id)
        {
            return _connection.Table<Contact>().FirstOrDefault(t => t.ID == id);

        }

        public void DeleteContact (int id)
        {
            _connection.Delete<Contact>(id);
        }
        public void AddContact(string firstName, string lastName, string contactType)
        {
            var newContact = new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                ContactType = contactType

            };
            _connection.Insert(newContact);
        }
        public void UpdateContact(int id, string firstName, string lastName, string contactType)
        {
            _connection.Execute("Update Contact Set FirstName = ?, LastName = ?, ContactType = ? Where ID = ?"
                ,firstName,lastName,contactType,id);
        }
        public int Count()
        {
            return _connection.Table<Contact>().Count();
        }
    }
}
