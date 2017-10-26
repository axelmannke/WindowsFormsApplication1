using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using PresentationLayer;

namespace WindowsFormsApplication1
{

    

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VKonto.WurzelKonten(treeView1, rbRec1.Checked);
            treeView1.ExpandAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((KontenBaum)treeView1.SelectedNode.Tag).SummeSoll().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            try
            {
                textBox1.Text = ((KontenBaum)e.Node.Tag).Soll.ToString();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KontenBaum k = new KontenBaum(3, true);
            TabPage tp = new TabPage(k.Beschreibung);
            tabControl1.TabPages.Add(tp);
            MyTab mt = new MyTab(k);
            tp.Controls.Add(mt);

            foreach (KontenBaum ko in k.UnterKonten)
            {
                TabPage tp1 = new TabPage(ko.Beschreibung);

                tabControl1.TabPages.Add(tp1);

                MyTab mt1 = new MyTab(ko);

                tp1.Controls.Add(mt1);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            VKonto.ErzeugeKindlein(e.Node, (KontenBaum)e.Node.Tag);

            e.Node.Expand();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kontoTreeView1.HoleWurzelKonten(rbRec1.Checked);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show(); f2.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DbKonto k = kontoTreeView1.SelectedKonto;

            k.Soll = double.Parse(txtSoll.Text);
            k.Haben = double.Parse(txtHaben.Text);

            k.Update();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
