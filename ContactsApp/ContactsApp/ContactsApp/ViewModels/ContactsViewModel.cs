using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ContactsApp.Models;
using MyClock.ViewModels;
using Xamarin.Forms;

namespace ContactsApp.ViewModels
{
    public class ContactsViewModel : ViewModelBase
    {


        private Contact conContact = new Contact();
        public static ContactsDB cDB = new ContactsDB();
        private static Contact selectedContact = null;
        private static Contact saveContact;

        public ContactsViewModel()
        {
            saveContact = new Contact();

            if (cDB.Count() == 0)
            {
                cDB.AddContact("Marvin", "Cochise", "Friend");
                cDB.AddContact("Bill", "Smith", "Friend");
                cDB.AddContact("Hugh", "Lowell", "Friend");
                cDB.AddContact("Josie", "Ficka", "Friend");
                cDB.AddContact("Pasha", "Netsky", "Russian");
                cDB.AddContact("Quana", "Parker", "Chief");


            }
            AddContactCommand = new Command(() =>
            {
                cDB.AddContact(conContact.FirstName, conContact.LastName, conContact.ContactType);
                Console.WriteLine("cDB.count: "+cDB.Count());

                Contact = new Contact();
            });

            SaveEditCommand = new Command(()=>
            {
                cDB.UpdateContact(selectedContact.ID, selectedContact.FirstName, selectedContact.LastName, selectedContact.ContactType); //'Object reference not set to an instance of an object.'                      
            });

            DeleteCommand = new Command(()=>           
            {
                cDB.DeleteContact(SelectedContact.ID);      
            });

            CancelEditCommand = new Command(() =>
            {
                cDB.UpdateContact(saveContact.ID, saveContact.FirstName, saveContact.LastName, saveContact.ContactType);               
            });

        }
        public Contact Contact
        {
            get => conContact;
            set
            {
                if (conContact != value)
                {
                    conContact = value;
                    OnPropertyChanged();
                }
            }
        }
        public Contact SelectedContact
        {
            get => selectedContact;
            set
            {
                if (value != null)
                {
                    saveContact.FirstName = value.FirstName;
                    saveContact.LastName = value.LastName;
                    saveContact.ContactType = value.ContactType;

                    selectedContact = value; 
                    OnPropertyChanged();

                }
            }
        }


        public ICommand AddContactCommand { get; protected set; }
        public ICommand SaveEditCommand { get; protected set; }
        public ICommand DeleteCommand { get; protected set; }
        public ICommand CancelEditCommand { get; protected set; }



        }
    }
         
    





