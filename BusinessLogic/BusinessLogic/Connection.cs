using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using Mk.DBConnector;

namespace BusinessLogic
{
    public static class Connection
    {
        public static DBAdapter adapter;

        static Connection()
        {
            
            adapter = new DBAdapter(DatabaseType.MySql, Instance.NewInstance, "localhost", 3306, "E3FI3", "root", "", "logfile.log");

            adapter.Adapter.LogFile = true;
        }
    }
}
