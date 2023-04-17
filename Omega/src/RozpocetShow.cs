using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace Omega
{
    public partial class RozpocetShow : Form
    {
        List<Produkt> productList = new List<Produkt>();
        int id;
        Rozpocet rozpocet = null;
        double total = 0;
        public RozpocetShow(int id)
        {
            this.FormClosed += Program.MyClosedHandler;
            this.id = id;
            InitializeComponent();
            foreach (Rozpocet r in Rozpocet.GetAllByNickname()) {
                if (r.Id == id) {
                    rozpocet = r;
                    break;
                }
            }
            this.custName_textbox.Text = rozpocet.Name_cust;
            this.CustSurname_textbox.Text = rozpocet.Surname_cust;
            foreach (Produkt p in rozpocet.Products) {
                this.product_list.Items.Add(p);
                this.productList.Add(p);
                this.total += (p.Price * p.Count);
            }
            this.total_label.Text = this.total.ToString() + ",-";
        }

        private void RozpocetShow_Load(object sender, System.EventArgs e)
        {
            this.searched_listBox.MouseDoubleClick += new MouseEventHandler(list_listBox_MouseDoubleClick);
        }
        /// <summary>
        /// Method <c>searched_listBox_MouseDoubleClick</c> gets index from double clicked item from searched_listBox and passes the texts to textBoxes
        /// </summary>
        private void list_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
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
            else
            {
                foreach (Produkt r in Program.initialize_products)
                {
                    if (Regex.IsMatch(r.Name.ToLower(), pattern.ToLower()))
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
        /// Method <c>add_button_Click</c> gets texts from textBoxes and appends them to productList and product_list listBox
        /// </summary>
        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.name_textbox.Text;
                string jednotka = this.jednotka_select.Text;
                double count = System.Convert.ToDouble(this.count_textbox.Text);
                double price = System.Convert.ToDouble(this.price_textbox.Text);
                productList.Add(new Produkt(name, price, jednotka, count));
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
                else
                {
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
                            this.total_label.Text = this.total.ToString() + ",-"; ;
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
        /// Method <c>back_button_Click</c> hides current form and shows RozpocetList form
        /// </summary>
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rozpocetList = new RozpocetList();
            rozpocetList.Show();
        }
        /// <summary>
        /// Method <c>save_button_Click</c> validates if textBoxes texts are in required patterns and then it will pass them to editList method
        /// </summary>
        private void save_button_Click(object sender, EventArgs e)
        {
            if (RegexValidator.one_nonDigit_Word(this.CustSurname_textbox.Text) && RegexValidator.one_nonDigit_Word(this.custName_textbox.Text))
            {
                if (this.product_list.Items.Count == 0)
                {
                    MessageBox.Show("Nezadali jste žádné položky do seznamu.");
                }
                else if (Rozpocet.editList(this.id, this.productList, this.custName_textbox.Text, this.CustSurname_textbox.Text) == true && !(this.product_list.Items.Count == 0))
                {
                    this.rozpocet.Name_cust = this.custName_textbox.Text;
                    this.rozpocet.Surname_cust = this.CustSurname_textbox.Text;
                    this.rozpocet.Products = this.productList;
                    MessageBox.Show("Upraveno");
                    this.Hide();
                    var menu = new Menu();
                    menu.Show();


                }
            }
            else
            {
                MessageBox.Show("Špatně zadané hodnoty jména nebo příjmení zákazníka");
            }
        }
    }
}
