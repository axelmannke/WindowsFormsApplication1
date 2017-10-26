using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace PresentationLayer
{
    public partial class KontoTreeView : UserControl
    {

        public DbKonto SelectedKonto
        {
            get
            {
                return (DbKonto)treeView1.SelectedNode.Tag;
            }
        }

        public KontoTreeView()
        {
            InitializeComponent();
        }

        public void HoleWurzelKonten(bool recursive)
        {
            VKonto.WurzelKonten(treeView1, recursive);
            treeView1.ExpandAll();
        }

        public void ErzeugeKindlein(TreeNode node, KontenBaum k)
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

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            VKonto.ErzeugeKindlein(e.Node, (KontenBaum)e.Node.Tag);

            //((KontoNode)e.Node).HoleKindlein();

            e.Node.Expand();
        }
    }
}
