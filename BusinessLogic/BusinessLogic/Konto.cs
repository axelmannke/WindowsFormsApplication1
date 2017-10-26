using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Mk.DBConnector;
using System.Windows.Forms;

namespace BusinessLogic
{

    public class DbKonto
    {
        public const string TKonto = "konten2";

        public int ID;
        public int IdParent;
        public string Beschreibung;
        public double Soll;
        public double Haben;

        public DbKonto(int id)
        {
            this.ID = id;
            string sql = string.Format(@"SELECT * FROM konten 
            WHERE idkonten = {0}", id);
            DataRow row = Connection.adapter.Adapter.GetDataRow(sql);

            Init(row);

        }

        public DbKonto(DataRow row)
        {
            Init(row);

            string sql = string.Format(@"SELECT * FROM {0} 
            WHERE konten_idkonten = {1} AND idkonten <> konten_idkonten", TKonto, ID);

            DataTable table = Connection.adapter.Adapter.GetDataTable(sql);
        }

        private void Init(DataRow row)
        {
            this.ID = int.Parse(row[0].ToString());
            this.IdParent = int.Parse(row[1].ToString());
            this.Beschreibung = row[2].ToString();
            this.Soll = double.Parse(row[3].ToString());
            this.Haben = double.Parse(row[4].ToString());
        }

        public void Update()
        {
            string sql = string.Format(@"Update {0}
            SET Beschreibung = '{1}', Soll = {2}, Haben = {3} 
            WHERE idkonten = {4}", TKonto, Beschreibung, Soll.ToString().Replace(",", "."), Haben.ToString().Replace(",", "."),  ID);

            Connection.adapter.Adapter.ExecuteSQL(sql);
        }
    }
    
}
