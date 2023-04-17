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
            this.FormClosed += Program.MyClosedHandler;
            InitializeComponent();
            this.password_textbox.PasswordChar = '\u25CF';
        }

        /// <summary>
        /// Method <c>login_button_Click</c> checks if nickname_textbox text and password_text are in good format by RegexValidator and then tries to validate the inputs with User methods and Codemanipulator methods
        /// </summary>
        
        private void login_button_Click(object sender, EventArgs e){
        string code = this.code_input.Text;
            
            if (!RegexValidator.one_digit_Word(this.nickname_textbox.Text))
            {
                MessageBox.Show("Špatný formát přihlašovacího jména");
            }
            else if (!RegexValidator.password(this.password_textbox.Text))
            {
                MessageBox.Show("Špatný formát hesla(musí mít minimálně 3 znaky)");
            }
            else if (this.code_input.Text == "") {
                MessageBox.Show("Kód nebyl zadán");
            }

                
            else
            {
                
                try
                {
                    CodeManipulator.validate_code(code);
                    User.exists(this.nickname_textbox.Text);
                    CodeManipulator.use(code);
                    User.register(this.nickname_textbox.Text, this.password_textbox.Text);
                    MessageBox.Show("Byl/a jste úspěšně zaregistrován/a");
                    this.Hide();
                    var login = new Login();
                    login.Show();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    
                   
            }
        }






        /// <summary>
        /// Method <c>checkBox1_CheckedChanged</c> changes password_textbox.text to password char "*" if showPassword button is checked and if not then its showed normally
        /// </summary>
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
        /// <summary>
        /// Method <c>back_button_Click</c> hides current form and shows Login form
        /// </summary>
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }

       
    }
}
