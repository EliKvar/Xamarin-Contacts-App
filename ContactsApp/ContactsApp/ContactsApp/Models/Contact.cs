using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ContactsApp.Models
{
    [Table("Contact")]
    public  class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactType { get; set; }
        public string FullName
        {
            get => FirstName +" " + LastName;
        }
        public Contact()
        {

        }
        public Contact(string firstName, string lastName, string contactType)
        {
            firstName = FirstName;
            lastName = LastName;
            contactType = ContactType;

        }
        
    }
}
