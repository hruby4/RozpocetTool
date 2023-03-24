using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Omega
{
    public partial class CreateRozpocet : Form
    {
        List<Produkt> productList = new List<Produkt>();
        public CreateRozpocet()
        {
            InitializeComponent();
            foreach (string r in Program.initialize_products) {
                this.searched_listBox.Items.Add(r);
            }
            MessageBox.Show(this.searched_listBox.Items.Add(Program.initialize_products.Count).ToString());
        }



        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.name_textbox.Text;
                string jednotka = this.jednotka_select.Text;
                double count = System.Convert.ToDouble(this.count_textbox.Text);
                double price = System.Convert.ToDouble(this.price_textbox.Text);
                productList.Add(new Produkt(name,price,jednotka,count));
                this.product_list.Items.Add(new Produkt(name, price, jednotka, count));
                this.name_textbox.Text = null;
                this.jednotka_select.Text = null;
                this.count_textbox.Text = null;
                this.price_textbox.Text = null;
                



            }
            catch
            {
                MessageBox.Show("Špatně zadané hodnoty");
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.product_list.Items.Contains(this.product_list.SelectedItem))
                {
                    this.product_list.Items.Add(this.product_list.SelectedItem);
                    this.product_list.Items.Remove(this.product_list.SelectedItem);
                    
                }
                else
                {
                    foreach (var x in this.productList)
                    {
                        if (((Produkt)this.product_list.SelectedItem).Name == x.Name)
                        {
                            this.productList.Remove(x);
                        break;
                        }

                    }
                    this.product_list.Items.Remove(this.product_list.SelectedItem);
                    
                    
                }

            }
            catch
            {
                MessageBox.Show("Nothing selected to remove");
            }
        }


        private void save_button_Click(object sender, EventArgs e)
        {
            
            if (RegexValidator.one_nonDigit_Word(this.CustSurname_textbox.Text) && RegexValidator.one_nonDigit_Word(this.custName_textbox.Text))
            {
                if (this.product_list.Items.Count == 0)
                {
                    MessageBox.Show("Nezadali jste žádné položky do seznamu.");
                }
                else if (Rozpocet.uploadList(productList, this.custName_textbox.Text, this.CustSurname_textbox.Text) == true && !(this.product_list.Items.Count == 0))
                {
                    productList.Clear();
                    this.product_list.Items.Clear();
                    this.custName_textbox.Text = null;
                    this.CustSurname_textbox.Text = null;
                    MessageBox.Show("Uloženo");
                }
            }
            else {
                MessageBox.Show("Špatně zadané hodnoty jména nebo příjmení zákazníka");
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            this.searched_listBox.Visible = true;
        }


    }
}
