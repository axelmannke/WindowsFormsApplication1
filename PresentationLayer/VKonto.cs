using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BusinessLogic;

namespace PresentationLayer
{
    public class VKonto
    {
        public KontenBaum konto;
        public TreeNode node;

        public VKonto(KontenBaum konto, bool recursive)
        {
            this.konto = konto;
            this.node = new TreeNode(this.konto.ToString());
            this.node.Tag = this.konto;

            if (recursive)
            {
                foreach (KontenBaum k in konto.UnterKonten)
                {
                    VKonto vk = new VKonto(k, true);
                    this.node.Nodes.Add(vk.node);
                }
            }
        }

        public static void WurzelKonten(TreeView tv, bool recursive)
        {
            List<VKonto> rootnodes = new List<VKonto>();

            string sql = string.Format(@"SELECT * FROM {0} WHERE idkonten = Konten_idkonten", KontenBaum.TKonto);

            DataRow row = Connection.adapter.Adapter.GetDataRow(sql);

            DataTable table = Connection.adapter.Adapter.GetDataTable(sql);

            foreach (DataRow r in table.Rows)
            {
                KontenBaum k = new KontenBaum(r, recursive);
                VKonto vk = new VKonto(k, recursive);

                tv.Nodes.Add(vk.node);
            }
        }

        public static void ErzeugeKindlein(TreeNode node, KontenBaum k)
        {
            if (!k.KinderSindDa)
            {
                k.HolDieKindlein();

                foreach (KontenBaum ki in k.UnterKonten)
                {
                    VKonto vk = new VKonto(ki, false);
                    node.Nodes.Add(vk.node);
                }
            }
        }
    }
}
