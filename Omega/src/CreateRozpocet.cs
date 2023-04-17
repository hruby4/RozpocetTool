using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Omega
{
    public partial class CreateRozpocet : Form
    {
        List<Produkt> productList = new List<Produkt>();
        double total = 0;


        public CreateRozpocet()
        {
            this.FormClosed += Program.MyClosedHandler;
            InitializeComponent();
        }


        /// <summary>
        /// Method <c>back_button_Click</c> hides current form and shows Menu form
        /// </summary>
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }

        /// <summary>
        /// Method <c>button1_Click</c> gets texts from textBoxes and appends them to productList and product_list listBox
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.name_textbox.Text;
                string jednotka = this.jednotka_select.Text;
                double count = System.Convert.ToDouble(this.count_textbox.Text);
                double price = System.Convert.ToDouble(this.price_textbox.Text);
                if (count > 0)
                {
                    this.total += (count * price);
                    this.total_label.Text = this.total.ToString() + ",-";
                    productList.Add(new Produkt(name, price, jednotka, count));
                    this.product_list.Items.Add(new Produkt(name, price, jednotka, count));
                    this.name_textbox.Text = null;
                    this.jednotka_select.Text = null;
                    this.price_textbox.Text = null;
                    this.count_textbox.Text = null;
                }
                else {
                    MessageBox.Show("Počet musí být číslo vetší než nula");
                }

            }
            catch
            {
                MessageBox.Show("Špatně zadané hodnoty");
            }
        }
        /// <summary>
        /// Method <c>remove_button_Click</c> removes items from productList and product_list listBox but only if some item was selected
        /// </summary>
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
                            this.total -= (x.Count * x.Price);
                            this.total_label.Text = this.total.ToString() + ",-";
                            this.productList.Remove(x);
                            break;
                        }

                    }
                    this.product_list.Items.Remove(this.product_list.SelectedItem);
                    
                    
                }

            }
            catch
            {
                MessageBox.Show("Nebylo vybráno nic k odebrání");
            }
        }

        /// <summary>
        /// Method <c>save_button_Click</c> validates if textBoxes texts are in required patterns and then it will try to pass them to uploadList method
        /// </summary>
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
               
                    MessageBox.Show("Uloženo");
                    this.Hide();
                    var menu = new Menu();
                    menu.Show();

                }
            }
            else {
                MessageBox.Show("Špatně zadané hodnoty jména nebo příjmení zákazníka");
            }
        }

        /// <summary>
        /// Method <c>search_button_Click</c> clears the search_listbox and then fills sorted products from Program.initialize_products and adds it into searched_listBox and then sorts the listBox
        /// </summary>
        private void search_button_Click(object sender, EventArgs e)
        {
            this.searched_listBox.Items.Clear();
            string pattern = this.search_textBox.Text;

            List<Produkt> sortedList = new List<Produkt>();
            if (pattern == "")
            {
                foreach (Produkt r in Program.initialize_products)
                {
                    sortedList.Add(r);
                }
            }
            else {
                foreach (Produkt r in Program.initialize_products)
                {
                    if (Regex.IsMatch(r.Name.ToLower(),pattern.ToLower()))
                    {
                        sortedList.Add(r);
                    }
                }
            }
            sortedList.Sort();
            foreach (Produkt r in sortedList)
            {
                this.searched_listBox.Items.Add(r);
            }
            
            this.searched_listBox.Visible = true;
        }

        /// <summary>
        /// Method <c>searched_listBox_MouseDoubleClick</c> gets index from double clicked item from searched_listBox and passes the texts to textBoxes
        /// </summary>
        void searched_listBox_MouseDoubleClick(object sender, MouseEventArgs e)

        {

            int index = this.searched_listBox.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)

            {
                this.name_textbox.Text = (((Produkt)this.searched_listBox.Items[index]).Name);
                this.jednotka_select.Text = (((Produkt)this.searched_listBox.Items[index]).Jednotka);
                this.price_textbox.Text = (((Produkt)this.searched_listBox.Items[index]).Price).ToString();
                this.count_textbox.Text = (((Produkt)this.searched_listBox.Items[index]).Count).ToString();

            }

        }

        /// <summary>
        /// Method <c>CreateRozpocet_Load</c> adds a searched_listBox_MouseDoubleClick to searched_listbox MouseDoubleClick
        /// </summary>
        private void CreateRozpocet_Load(object sender, EventArgs e)
        {
            this.searched_listBox.MouseDoubleClick += new MouseEventHandler(searched_listBox_MouseDoubleClick);
        }

        
    }
}
