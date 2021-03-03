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
    public partial class EditDeleteContactViewPage : ContentPage
    {
        public EditDeleteContactViewPage()
        {
            InitializeComponent();
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();

        }
    }
}