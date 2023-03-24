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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CustSurname_textbox = new System.Windows.Forms.TextBox();
            this.custName_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.count_textbox = new System.Windows.Forms.TextBox();
            this.jednotka_select = new System.Windows.Forms.ComboBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.product_list = new System.Windows.Forms.ListBox();
            this.back_button = new System.Windows.Forms.Button();
            this.rozpocetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rozpocetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Příjmení";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Jméno";
            // 
            // CustSurname_textbox
            // 
            this.CustSurname_textbox.Location = new System.Drawing.Point(121, 284);
            this.CustSurname_textbox.Name = "CustSurname_textbox";
            this.CustSurname_textbox.Size = new System.Drawing.Size(215, 20);
            this.CustSurname_textbox.TabIndex = 54;
            // 
            // custName_textbox
            // 
            this.custName_textbox.Location = new System.Drawing.Point(121, 242);
            this.custName_textbox.Name = "custName_textbox";
            this.custName_textbox.Size = new System.Drawing.Size(215, 20);
            this.custName_textbox.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Zákazník";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save_button.Location = new System.Drawing.Point(864, 561);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(143, 26);
            this.save_button.TabIndex = 51;
            this.save_button.Text = "Uložit";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Cena za ks/kg/m²";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Počet";
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
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(121, 100);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(215, 20);
            this.price_textbox.TabIndex = 46;
            // 
            // count_textbox
            // 
            this.count_textbox.Location = new System.Drawing.Point(121, 74);
            this.count_textbox.Name = "count_textbox";
            this.count_textbox.Size = new System.Drawing.Size(215, 20);
            this.count_textbox.TabIndex = 45;
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
            this.jednotka_select.Location = new System.Drawing.Point(12, -35);
            this.jednotka_select.Name = "jednotka_select";
            this.jednotka_select.Size = new System.Drawing.Size(215, 21);
            this.jednotka_select.TabIndex = 44;
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(506, 419);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(427, 20);
            this.remove_button.TabIndex = 43;
            this.remove_button.Text = "Smazat";
            this.remove_button.UseVisualStyleBackColor = true;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(12, -62);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(215, 20);
            this.name_textbox.TabIndex = 42;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(189, 146);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(70, 20);
            this.add_button.TabIndex = 41;
            this.add_button.Text = "Přidat";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // product_list
            // 
            this.product_list.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.rozpocetBindingSource, "Id", true));
            this.product_list.FormattingEnabled = true;
            this.product_list.Location = new System.Drawing.Point(425, 12);
            this.product_list.Name = "product_list";
            this.product_list.Size = new System.Drawing.Size(582, 394);
            this.product_list.TabIndex = 40;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_button.Location = new System.Drawing.Point(15, 561);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(143, 26);
            this.back_button.TabIndex = 39;
            this.back_button.Text = "Zpět";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // rozpocetBindingSource
            // 
            this.rozpocetBindingSource.DataSource = typeof(Omega.Rozpocet);
            // 
            // RozpocetShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 667);
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
            this.Name = "RozpocetShow";
            this.Text = "RozpocetShow";
            ((System.ComponentModel.ISupportInitialize)(this.rozpocetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustSurname_textbox;
        private System.Windows.Forms.TextBox custName_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox count_textbox;
        private System.Windows.Forms.ComboBox jednotka_select;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ListBox product_list;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.BindingSource rozpocetBindingSource;
    }
}