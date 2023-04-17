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
            this.FormClosed += Program.MyClosedHandler;
            InitializeComponent();
            if (Login.Nick == "admin") {
                this.generateCode_button.Visible = true;
            }
        }
        
        /// <summary>
        /// Method <c>button1_Click</c> hides current form and shows CreateRozpocet form
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var createRozpocet = new CreateRozpocet();
            createRozpocet.Show();

        }

        /// <summary>
        /// Method <c>back_button_Click</c> hides current form and shows Login form
        /// </summary>
        private void back_button_Click(object sender, EventArgs e)
        {
            Login.Nick = "";
            this.Hide();
            var login = new Login();
            login.Show();
        }

        /// <summary>
        /// Method <c>generateCode_button_Click</c> sets code_panel to visible and sets the code_label text to randomized code by Codemanipulator.GenerateCode method 
        /// </summary>
        private void generateCode_button_Click(object sender, EventArgs e)
        {
            this.code_panel.Visible = true;
            this.code_label.Text = CodeManipulator.GenerateCode();
        }

        /// <summary>
        /// Method <c>listOrder_button_Click</c> hides current form and shows RozpocetList form
        /// </summary>
        private void listOrder_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RozpocetList = new RozpocetList();
            RozpocetList.Show();
        }

        /// <summary>
        /// Method <c>kopírovat_Click</c> sets clipboard text to code_label text 
        /// </summary>
        private void kopírovat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(this.code_label.Text, true);
        }

        /// <summary>
        /// Method <c>close_panel_Click</c> set code_panel to not Visible and sets the code_label text to "" 
        /// </summary>
        private void close_panel_Click(object sender, EventArgs e)
        {
            this.code_panel.Visible = false;
            this.code_label.Text = "";
        }
    }
}
