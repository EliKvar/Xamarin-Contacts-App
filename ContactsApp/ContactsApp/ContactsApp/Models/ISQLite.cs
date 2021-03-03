using System;
using SQLite;

namespace ContactsApp.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
