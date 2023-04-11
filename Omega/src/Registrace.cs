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
            this.FormClosed += MyClosedHandler;
            InitializeComponent();
            this.password_textbox.PasswordChar = '\u25CF';
        }

        protected void MyClosedHandler(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string code = this.code_input.Text;
            try
            {
                if (!RegexValidator.one_digit_Word(this.nickname_textbox.Text))
                {
                    MessageBox.Show("Šatný formát přihlašovacího jména");
                }
                else if (!RegexValidator.password(this.password_textbox.Text))
                {
                    MessageBox.Show("Šatný formát hesla(musí mít minimálně 3 znaky)");
                }
                else if (this.code_input.Text == "") {
                    MessageBox.Show("Kód nebyl zadán");
                }

                
                else
                {
                    if ((User.register(this.nickname_textbox.Text, this.password_textbox.Text)))
                    {
                        CodeManipulator.use(code);
                        MessageBox.Show("Byl/a jste úspěšně zaregistrován/a");
                        this.Hide();
                        var login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Chyba v registraci");
                    }
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }


            
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
