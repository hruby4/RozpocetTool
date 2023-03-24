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
    public partial class RozpocetList : Form
    {
        public RozpocetList()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }

        private void list_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RozpocetList_Load(object sender, EventArgs e)
        {
            foreach (Rozpocet r in Rozpocet.GetAllByNickname()) {
                this.list_listBox.Items.Add(r);
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if (this.list_listBox.SelectedItem != null) {
                this.Hide();
                int id = ((Rozpocet)this.list_listBox.SelectedItem).Id;
                var RozpocetShow = new RozpocetShow(id);
                RozpocetShow.Show();
            }
        }
    }
}
