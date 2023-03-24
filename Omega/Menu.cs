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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Login.Nick == "admin") {
                this.generateCode_button.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var createRozpocet = new CreateRozpocet();
            createRozpocet.Show();

        }

       
        private void back_button_Click(object sender, EventArgs e)
        {
            Login.Nick = "";
            this.Hide();
            var login = new Login();
            login.Show();
        }

        private void generateCode_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CodeManipulator.GenerateCode());
        }

        private void listOrder_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RozpocetList = new RozpocetList();
            RozpocetList.Show();
        }

    }
}
