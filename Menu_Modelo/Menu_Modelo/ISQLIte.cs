using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Menu_Modelo
{
    public interface ISQLIte
    {
        SQLiteConnection GetConnection();
    }
}
