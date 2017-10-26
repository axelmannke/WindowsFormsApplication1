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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           ucKonto kt = new ucKonto(kontoTreeView1.SelectedKonto);

            kt.ShowMe(tabControl1);
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

        }
    }
}
