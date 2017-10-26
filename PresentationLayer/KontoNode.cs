using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using System.Data;

namespace PresentationLayer
{
    public class KontoNode : TreeNode
    {
        public KontenBaum Konto;

        public KontoNode(KontenBaum node) : base()
        {
            this.Konto = node;

            this.Text = this.Konto.ToString();
        }
        public KontoNode(DataRow row) : base()
        {
            this.Konto = new KontenBaum(row, false);

            this.Text = this.Konto.ToString(); 
        }

        public new List<KontoNode> Nodes = new List<KontoNode>();

        public void HoleKindlein()
        {
            Konto.HolDieKindlein();

            foreach(KontenBaum k in Konto.UnterKonten)
            {
                this.Nodes.Add(new KontoNode(k));
            }
        }


    }
}
