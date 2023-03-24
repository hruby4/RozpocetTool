using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public partial class RozpocetShow : Form
    {
        public RozpocetShow(int id)
        {
            InitializeComponent();
            MessageBox.Show(id.ToString());
        }

    }
}
