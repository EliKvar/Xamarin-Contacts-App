using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System;
using System.IO;
using Xamarin.Forms;
using SQLite;
using ContactsApp.Droid;
using ContactsApp.Models;

[assembly: Dependency(typeof(SQLite_Android))]


namespace ContactsApp.Droid
{
    public class SQLite_Android: ISQLite
    {
        public SQLite_Android()
        {
        }
        #region ISQLite implementation

        public SQLiteConnection GetConnection()
        {
            var fileName = "Contacts.db3";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);
            var connection = new SQLiteConnection(path);
            return connection;
        }

        
        #endregion
    }

}