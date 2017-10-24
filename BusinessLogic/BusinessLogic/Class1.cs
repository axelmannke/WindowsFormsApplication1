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
    public class Owner
    {
        public string Name;
        public Owner()
        {

        }

        public override string ToString()
        {
            return this.Name;
        }
    }

    public class OwnerCollection
    {
        public List<Owner> Owners = new List<Owner>();
        public OwnerCollection()
        {
            DBAdapter ad = new DBAdapter(DatabaseType.PostgreSQL, Instance.NewInstance, "localhost", 5432, "E3FI3", "visualis", "visualis", "logfile.log");

            ad.Adapter.LogFile = true;

            DataTable t = ad.Adapter.GetDataTable("SELECT * FROM owner;");

            foreach (DataRow r in t.Rows)
            {
                Owner owner = new Owner();
                owner.Name = r[1].ToString();

                this.Owners.Add(owner);
            }
        }

        public void Show(ListBox lbGui)
        {
            foreach (Owner ow in this.Owners)
            {
                lbGui.Items.Add(ow.ToString());
            }
        }
    }

    public class KFZ
    {
        public Halter owner;

        public KFZ()
        {
            this.owner = new Halter();
        }
    }

    public class Halter
    {
        public string Name; 
    }
}
