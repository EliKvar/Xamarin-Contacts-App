using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ContactsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactViewPage : ContentPage
    {
        public AddContactViewPage()
        {
            InitializeComponent();
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void Button_Pressed_1(object sender, EventArgs e)
        {

        }
    }
}