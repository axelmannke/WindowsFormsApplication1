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

    static class Connection
    {
        public static DBAdapter adapter;

        static Connection()
        {
            adapter = new DBAdapter(DatabaseType.MySql, Instance.NewInstance, "localhost", 3306, "E3FI3", "root", "np012345", "logfile.log");

            adapter.Adapter.LogFile = true;
        }
    }

    public class Konto
    {
        public int ID;
        public int IdParent;
        public string Beschreibung;
        public double Soll;
        public double Haben;

        public List<Konto> UnterKonten = new List<Konto>();
        //public TreeNode node;

        
        public Konto(int id)
        {
            this.ID = id;
            string sql = string.Format(@"SELECT * FROM konten 
            WHERE idkonten = {0}", id);
            DataRow row = Connection.adapter.Adapter.GetDataRow(sql);

            this.IdParent = int.Parse(row[1].ToString());
            this.Beschreibung = row[2].ToString();
            this.Soll = double.Parse(row[3].ToString());
            this.Haben = double.Parse(row[4].ToString());

            //this.node = new TreeNode(this.Beschreibung);
            //this.node.Tag = this;

            sql = string.Format(@"SELECT * FROM konten 
            WHERE konten_idkonten = {0}", id);

            DataTable table = Connection.adapter.Adapter.GetDataTable(sql);

            foreach(DataRow r in table.Rows)
            {
                Konto k = new BusinessLogic.Konto(r);
                //this.node.Nodes.Add(k.node);

                this.UnterKonten.Add(k);
            }
        }

        public Konto()
        {
            string sql = string.Format(@"SELECT * FROM konten WHERE Konten_idkonten = 0");
            DataRow row = Connection.adapter.Adapter.GetDataRow(sql);

    
            DataTable table = Connection.adapter.Adapter.GetDataTable(sql);

            foreach (DataRow r in table.Rows)
            {
                Konto k = new BusinessLogic.Konto(r);
                //this.node.Nodes.Add(k.node);

                this.UnterKonten.Add(k);
            }
        }
        public Konto(DataRow row)
        {
            this.ID = int.Parse(row[0].ToString());
            this.IdParent = int.Parse(row[1].ToString());
            this.Beschreibung = row[2].ToString();
            this.Soll = double.Parse(row[3].ToString());
            this.Haben = double.Parse(row[4].ToString());

            //this.node = new TreeNode(this.Beschreibung);
            //this.node.Tag = this;

            string sql = string.Format(@"SELECT * FROM konten 
            WHERE konten_idkonten = {0}", ID);

            DataTable table = Connection.adapter.Adapter.GetDataTable(sql);

            foreach (DataRow r in table.Rows)
            {
                Konto k = new BusinessLogic.Konto(r);
                //this.node.Nodes.Add(k.node);

                this.UnterKonten.Add(k);
            }
        }
    }


    public class VKonto
    {
        public Konto konto;
        public TreeNode node;

        public VKonto(Konto konto)
        {
            this.konto = konto;
            this.node = new TreeNode(this.konto.Beschreibung);
            this.node.Tag = this.konto;

            foreach (Konto k in konto.UnterKonten)
            {
                VKonto vk = new VKonto(k);
                this.node.Nodes.Add(vk.node);
            }
        }
    }


    public class RootKonten
    {
        public RootKonten(TreeView tv)
        {
            string sql = string.Format(@"SELECT * FROM konten WHERE Konten_idkonten = 0");
            DataRow row = Connection.adapter.Adapter.GetDataRow(sql);

            DataTable table = Connection.adapter.Adapter.GetDataTable(sql);

            foreach (DataRow r in table.Rows)
            {
                Konto k = new BusinessLogic.Konto(r);
                VKonto vk = new VKonto(k);

                tv.Nodes.Add(vk.node);
            }
        }
    }
}
