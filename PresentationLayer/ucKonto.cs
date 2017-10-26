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
    public partial class ucKonto : UserControl
    {
        private DbKonto konto;
        public ucKonto(DbKonto konto)
        {
            InitializeComponent();

            this.konto = konto;

            txtHaben.Text = konto.Haben.ToString();
            txtSoll.Text = konto.Soll.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            konto.Soll = double.Parse(txtSoll.Text);
            konto.Haben = double.Parse(txtHaben.Text);

            konto.Update();
        }

        public void ShowMe(TabControl tabC)
        {
            TabPage tp = new TabPage(konto.Beschreibung);
            tp.Controls.Add(this);
            tp.Controls[0].Dock = DockStyle.Fill;

            tabC.TabPages.Add(tp);
        }
    }
}
