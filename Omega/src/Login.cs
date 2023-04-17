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
            this.FormClosed += Program.MyClosedHandler;
            InitializeComponent();
            this.password_textbox.PasswordChar = '\u25CF';
        }

        

        /// <summary>
        /// Method <c>button1_Click</c> validates nickaname_textBox and password_textBox.Text and if yes then it will hide this form and show Menu form
        /// </summary>
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
        /// <summary>
        /// Method <c>button2_Click</c> hides current form and shows Registrace form
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrace = new Registrace();
            registrace.Show();
        }


        /// <summary>
        /// Method <c>checkBox1_CheckedChanged</c> changes password_textbox.text to password char "*" if showPassword button is checked and if not then its showed normally
        /// </summary>
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
