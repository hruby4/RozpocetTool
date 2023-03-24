using MySql.Data.MySqlClient;
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
    public partial class Registrace : Form
    {
        public Registrace()
        {
            InitializeComponent();
            this.password_textbox.PasswordChar = '\u25CF';
        }


        
        private void login_button_Click(object sender, EventArgs e)
        {
            string code = this.code_input.Text;
            if (!CodeManipulator.validate_code(code))
            {

                if (CodeManipulator.used_code(code))
                {
                    MessageBox.Show("Tento kod jiz byl pouzit");
                }
                else {
                    MessageBox.Show("Tento kod neexistuje");
                }
            }
            else {
                if (!RegexValidator.one_digit_Word(this.password_textbox.Text)) {
                    MessageBox.Show("Spatny format prihlasovaciho jmena");
                }
                else if (!RegexValidator.password("Spatny format hesla(musi mit minimalne 3 znaky)")) {
                    MessageBox.Show("Spatny format hesla(musi mit minimalne 3 znaky)");
                }
                else 
                {
                    if ((User.register(this.nickname_textbox.Text, this.password_textbox.Text)))
                    {
                        CodeManipulator.use(code);
                        MessageBox.Show("Byl/a jste uspesne zaregistrovan/a");
                        this.Hide();
                        var login = new Login();
                        login.Show();
                    }
                    else {
                        MessageBox.Show("Chyba v registraci");
                    }
                }
                
            }
        }

        

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        private void showPassword_button_CheckedChanged(object sender, EventArgs e)
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

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }

       
    }
}
