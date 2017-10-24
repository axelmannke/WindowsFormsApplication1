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

namespace WindowsFormsApplication1
{

    

    public partial class Form1 : Form
    {
        private Halter halter;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Konto k = new Konto(3);
            //treeView1.Nodes.Add(k.node);

            //VKonto vk = new VKonto(k);

            //treeView1.Nodes.Add(vk.node);

            RootKonten rk = new RootKonten(treeView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(this.halter.Name);
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode n = treeView1.SelectedNode;

            try
            {
                textBox1.Text = ((Konto)n.Tag).Soll.ToString();
            }
            catch { }
        }
    }
}
