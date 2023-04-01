namespace Omega
{
    partial class RozpocetShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.button2 = new System.Windows.Forms.Button();
            this.product_list = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.jednotka_select = new System.Windows.Forms.ComboBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.count_textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.custName_textbox = new System.Windows.Forms.TextBox();
            this.CustSurname_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.searched_listBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rozpocetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rozpocetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-55, -27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Jednotka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-87, -55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Název produktu";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(23, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 26);
            this.button2.TabIndex = 52;
            this.button2.Text = "Zpět";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // product_list
            // 
            this.product_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.product_list.FormattingEnabled = true;
            this.product_list.ItemHeight = 12;
            this.product_list.Location = new System.Drawing.Point(555, 123);
            this.product_list.Name = "product_list";
            this.product_list.Size = new System.Drawing.Size(578, 352);
            this.product_list.TabIndex = 53;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_button.Location = new System.Drawing.Point(291, 357);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(104, 32);
            this.add_button.TabIndex = 54;
            this.add_button.Text = "Přidat";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(182, 243);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(334, 20);
            this.name_textbox.TabIndex = 55;
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Red;
            this.remove_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.remove_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.remove_button.Location = new System.Drawing.Point(555, 481);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(578, 52);
            this.remove_button.TabIndex = 56;
            this.remove_button.Text = "Smazat";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // jednotka_select
            // 
            this.jednotka_select.FormattingEnabled = true;
            this.jednotka_select.Items.AddRange(new object[] {
            "ks",
            "kg",
            "m2",
            "cm",
            "cm2",
            "m",
            "h",
            "l",
            "ml"});
            this.jednotka_select.Location = new System.Drawing.Point(182, 270);
            this.jednotka_select.Name = "jednotka_select";
            this.jednotka_select.Size = new System.Drawing.Size(334, 21);
            this.jednotka_select.TabIndex = 57;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(182, 301);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(334, 20);
            this.price_textbox.TabIndex = 58;
            // 
            // count_textbox
            // 
            this.count_textbox.Location = new System.Drawing.Point(182, 331);
            this.count_textbox.Name = "count_textbox";
            this.count_textbox.Size = new System.Drawing.Size(334, 20);
            this.count_textbox.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Název produktu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Jednotka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Počet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Cena za ks/kg/m²";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(975, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 26);
            this.button1.TabIndex = 64;
            this.button1.Text = "Uložit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Zákazník";
            // 
            // custName_textbox
            // 
            this.custName_textbox.Location = new System.Drawing.Point(182, 455);
            this.custName_textbox.Name = "custName_textbox";
            this.custName_textbox.Size = new System.Drawing.Size(215, 20);
            this.custName_textbox.TabIndex = 66;
            // 
            // CustSurname_textbox
            // 
            this.CustSurname_textbox.Location = new System.Drawing.Point(182, 497);
            this.CustSurname_textbox.Name = "CustSurname_textbox";
            this.CustSurname_textbox.Size = new System.Drawing.Size(215, 20);
            this.CustSurname_textbox.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Jméno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Příjmení";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(215, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 73;
            this.label8.Text = "Najít produkt";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(76, 65);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(440, 20);
            this.search_textBox.TabIndex = 70;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(522, 65);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(93, 21);
            this.search_button.TabIndex = 71;
            this.search_button.Text = "Najít";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // searched_listBox
            // 
            this.searched_listBox.FormattingEnabled = true;
            this.searched_listBox.Location = new System.Drawing.Point(76, 85);
            this.searched_listBox.Name = "searched_listBox";
            this.searched_listBox.Size = new System.Drawing.Size(440, 108);
            this.searched_listBox.TabIndex = 72;
            this.searched_listBox.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(761, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 25);
            this.label9.TabIndex = 74;
            this.label9.Text = "Seznam položek";
            // 
            // rozpocetBindingSource
            // 
            this.rozpocetBindingSource.DataSource = typeof(Omega.Rozpocet);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(549, 536);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 33);
            this.label12.TabIndex = 76;
            this.label12.Text = "Celkově:";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.total_label.Location = new System.Drawing.Point(680, 538);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(32, 33);
            this.total_label.TabIndex = 77;
            this.total_label.Text = "0";
            // 
            // RozpocetShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 667);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searched_listBox);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustSurname_textbox);
            this.Controls.Add(this.custName_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.count_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.jednotka_select);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.product_list);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RozpocetShow";
            this.Text = "RozpocetShow";
            this.Load += new System.EventHandler(this.RozpocetShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rozpocetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource rozpocetBindingSource;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox product_list;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.ComboBox jednotka_select;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox count_textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custName_textbox;
        private System.Windows.Forms.TextBox CustSurname_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.ListBox searched_listBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label total_label;
    }
}