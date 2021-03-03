using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ContactsApp.ViewModels;
using ContactsApp.Views;

namespace ContactsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsListViewPage : ContentPage
    {
        public ContactsListViewPage()
        {
            InitializeComponent();
            contactsListView.ItemSelected += (sender, args) =>
            {
                if (contactsListView.SelectedItem == null) return;
                Navigation.PushModalAsync(new EditDeleteContactViewPage());

            };
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddContactViewPage());
        }
        protected override void OnAppearing()
        {
            contactsListView.ItemsSource = ContactsViewModel.cDB.GetContacts();
        }

    }
}