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
    public partial class MyTab : UserControl
    {
        public MyTab(KontenBaum k)
        {
            InitializeComponent();

            txtHaben.Text = k.Haben.ToString();
            txtSoll.Text = k.Soll.ToString();
        }
    }
}
