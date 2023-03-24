using System;

namespace Omega
{
    partial class CreateRozpocet
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
            this.back_button = new System.Windows.Forms.Button();
            this.product_list = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.jednotka_select = new System.Windows.Forms.ComboBox();
            this.count_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.custName_textbox = new System.Windows.Forms.TextBox();
            this.CustSurname_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.searched_listBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_button.Location = new System.Drawing.Point(12, 567);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(143, 26);
            this.back_button.TabIndex = 20;
            this.back_button.Text = "Zpět";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // product_list
            // 
            this.product_list.FormattingEnabled = true;
            this.product_list.Location = new System.Drawing.Point(704, 18);
            this.product_list.Name = "product_list";
            this.product_list.Size = new System.Drawing.Size(300, 355);
            this.product_list.TabIndex = 21;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(183, 322);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(70, 20);
            this.add_button.TabIndex = 22;
            this.add_button.Text = "Přidat";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(115, 188);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(215, 20);
            this.name_textbox.TabIndex = 23;
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Red;
            this.remove_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.remove_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.remove_button.Location = new System.Drawing.Point(704, 392);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(300, 52);
            this.remove_button.TabIndex = 24;
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
            "m",
            "h"});
            this.jednotka_select.Location = new System.Drawing.Point(115, 215);
            this.jednotka_select.Name = "jednotka_select";
            this.jednotka_select.Size = new System.Drawing.Size(215, 21);
            this.jednotka_select.TabIndex = 26;
            // 
            // count_textbox
            // 
            this.count_textbox.Location = new System.Drawing.Point(115, 246);
            this.count_textbox.Name = "count_textbox";
            this.count_textbox.Size = new System.Drawing.Size(215, 20);
            this.count_textbox.TabIndex = 27;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(115, 276);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(215, 20);
            this.price_textbox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Název produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Jednotka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Počet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cena za ks/kg/m²";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save_button.Location = new System.Drawing.Point(861, 567);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(143, 26);
            this.save_button.TabIndex = 33;
            this.save_button.Text = "Uložit";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Zákazník";
            // 
            // custName_textbox
            // 
            this.custName_textbox.Location = new System.Drawing.Point(115, 418);
            this.custName_textbox.Name = "custName_textbox";
            this.custName_textbox.Size = new System.Drawing.Size(215, 20);
            this.custName_textbox.TabIndex = 35;
            // 
            // CustSurname_textbox
            // 
            this.CustSurname_textbox.Location = new System.Drawing.Point(115, 460);
            this.CustSurname_textbox.Name = "CustSurname_textbox";
            this.CustSurname_textbox.Size = new System.Drawing.Size(215, 20);
            this.CustSurname_textbox.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Jméno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Příjmení";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(115, 18);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(440, 20);
            this.search_textBox.TabIndex = 39;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(567, 16);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(78, 21);
            this.search_button.TabIndex = 40;
            this.search_button.Text = "Najít";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // searched_listBox
            // 
            this.searched_listBox.FormattingEnabled = true;
            this.searched_listBox.Location = new System.Drawing.Point(115, 38);
            this.searched_listBox.Name = "searched_listBox";
            this.searched_listBox.Size = new System.Drawing.Size(440, 108);
            this.searched_listBox.TabIndex = 41;
            this.searched_listBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Najít produkt";
            // 
            // CreateRozpocet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 605);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searched_listBox);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustSurname_textbox);
            this.Controls.Add(this.custName_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.count_textbox);
            this.Controls.Add(this.jednotka_select);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.product_list);
            this.Controls.Add(this.back_button);
            this.Name = "CreateRozpocet";
            this.Text = "CreateRozpocet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        



        #endregion
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ListBox product_list;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.ComboBox jednotka_select;
        private System.Windows.Forms.TextBox count_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custName_textbox;
        private System.Windows.Forms.TextBox CustSurname_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.ListBox searched_listBox;
        private System.Windows.Forms.Label label8;
    }
}