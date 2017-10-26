using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Mk.DBConnector;


namespace BusinessLogic
{
    public class KontenBaum : DbKonto
    {
        public int IchHabeSovieleKindlein = 0;

        public List<KontenBaum> UnterKonten = new List<KontenBaum>();

        public bool KinderSindDa = false;


        public KontenBaum(int id, bool recursive) : base(id)
        {
            AnzahlKinder();

            if (!this.KinderSindDa)
            {
                this.KinderSindDa = true;

                if (recursive)
                {
                    string sql = string.Format(@"SELECT * FROM {0} 
                WHERE konten_idkonten = {1} AND idkonten <> konten_idkonten", TKonto, id);

                    DataTable table = Connection.adapter.Adapter.GetDataTable(sql);

                    foreach (DataRow r in table.Rows)
                    {
                        KontenBaum k = new KontenBaum(r, true);
                        this.UnterKonten.Add(k);
                    }
                }
            }
        }

        private void AnzahlKinder()
        {
            string sql = string.Format(@"SELECT COUNT(*) FROM {0} 
                WHERE konten_idkonten = {1} AND idkonten <> konten_idkonten", TKonto, this.ID);

            DataRow r = Connection.adapter.Adapter.GetDataRow(sql);

            this.IchHabeSovieleKindlein = int.Parse(r[0].ToString());
        }


        public KontenBaum(DataRow row, bool recursive) : base(row)
        {
            AnzahlKinder();

            if (recursive)
            {
                KinderSindDa = true;

                string sql = string.Format(@"SELECT * FROM {0} 
                    WHERE konten_idkonten = {1} AND idkonten <> konten_idkonten", TKonto, ID);

                DataTable table = Connection.adapter.Adapter.GetDataTable(sql);

                foreach (DataRow r in table.Rows)
                {
                    KontenBaum k = new KontenBaum(r, true);
                    this.UnterKonten.Add(k);
                }
            }
        }

        public static List<KontenBaum> WurzelKonten(bool recursive)
        {
            List<KontenBaum> rootnodes = new List<KontenBaum>();

            string sql = string.Format(@"SELECT * FROM {0} WHERE idkonten = Konten_idkonten", KontenBaum.TKonto);

            DataRow row = Connection.adapter.Adapter.GetDataRow(sql);

            DataTable table = Connection.adapter.Adapter.GetDataTable(sql);

            if (recursive)
            {
                foreach (DataRow r in table.Rows)
                {
                    KontenBaum k = new KontenBaum(r, true);
                }
            }

            return rootnodes;
        }

        public void HolDieKindlein()
        {
            string sql = string.Format(@"SELECT * FROM {0} 
                WHERE konten_idkonten = {1} AND idkonten <> konten_idkonten", TKonto, this.ID);

            DataTable table = Connection.adapter.Adapter.GetDataTable(sql);

            foreach (DataRow r in table.Rows)
            {
                UnterKonten.Add(new KontenBaum(r, false));
            }

            KinderSindDa = true;
        }

        public double SummeSoll()
        {
            double s = this.Soll;

            foreach (KontenBaum k in this.UnterKonten)
            {
                s += k.SummeSoll();
            }

            return s;
        }

        public override string ToString()
        {
            string s = string.Format("{0} [{1} | {2}]", Beschreibung, Soll, Haben);

            if (IchHabeSovieleKindlein > 0)
                return "+" + s;
            else
                return s;
        }
    }
}
