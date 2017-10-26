using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public partial class AccountNode : Component
    {
        public AccountNode()
        {
            InitializeComponent();
        }

        public AccountNode(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
