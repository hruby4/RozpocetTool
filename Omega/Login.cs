using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Omega
{
    public partial class Login : Form
    {
        private static string nick;

        public static string Nick { get => nick; set => nick = value; }

        public Login()
        {
            InitializeComponent();
            this.password_textbox.PasswordChar = '\u25CF';
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (RegexValidator.one_digit_Word(this.nickname_textbox.Text) && this.password_textbox.Text != "")
            {
                if (User.validate_login(this.nickname_textbox.Text, this.password_textbox.Text))
                {
                    nick = this.nickname_textbox.Text;
                    this.Hide();
                    var menu = new Menu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Špatné přihlašovací údaje");
                }
            }

            else {
                MessageBox.Show("Špatné přihlašovací údaje");
            }

            
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrace = new Registrace();
            registrace.Show();
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showPassword_button.Checked)
            {
                this.password_textbox.PasswordChar = '\0';
            }
            else
            {
                this.password_textbox.PasswordChar = '\u25CF';
            }

        }
    }
}
