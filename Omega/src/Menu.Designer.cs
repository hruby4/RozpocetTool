using System;

namespace Omega
{
    partial class Menu
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
            this.addOrder_button = new System.Windows.Forms.Button();
            this.listOrder_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.code_panel = new System.Windows.Forms.Panel();
            this.close_panel = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.Button();
            this.code_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.generateCode_button = new System.Windows.Forms.Button();
            this.logOut_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.code_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addOrder_button
            // 
            this.addOrder_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrder_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addOrder_button.BackColor = System.Drawing.Color.White;
            this.addOrder_button.Location = new System.Drawing.Point(39, 25);
            this.addOrder_button.Name = "addOrder_button";
            this.addOrder_button.Size = new System.Drawing.Size(270, 40);
            this.addOrder_button.TabIndex = 0;
            this.addOrder_button.Text = "Vytvořit rozpočet";
            this.addOrder_button.UseVisualStyleBackColor = false;
            this.addOrder_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOrder_button
            // 
            this.listOrder_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listOrder_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listOrder_button.BackColor = System.Drawing.Color.White;
            this.listOrder_button.Location = new System.Drawing.Point(39, 90);
            this.listOrder_button.Name = "listOrder_button";
            this.listOrder_button.Size = new System.Drawing.Size(270, 40);
            this.listOrder_button.TabIndex = 1;
            this.listOrder_button.Text = "Moje rozpočty";
            this.listOrder_button.UseVisualStyleBackColor = false;
            this.listOrder_button.Click += new System.EventHandler(this.listOrder_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.code_panel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logOut_button);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 638);
            this.panel1.TabIndex = 2;
            // 
            // code_panel
            // 
            this.code_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.code_panel.BackColor = System.Drawing.Color.SaddleBrown;
            this.code_panel.Controls.Add(this.close_panel);
            this.code_panel.Controls.Add(this.copy_button);
            this.code_panel.Controls.Add(this.code_label);
            this.code_panel.Location = new System.Drawing.Point(385, 161);
            this.code_panel.Name = "code_panel";
            this.code_panel.Size = new System.Drawing.Size(367, 212);
            this.code_panel.TabIndex = 23;
            this.code_panel.Visible = false;
            // 
            // close_panel
            // 
            this.close_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.close_panel.Location = new System.Drawing.Point(274, 171);
            this.close_panel.Name = "close_panel";
            this.close_panel.Size = new System.Drawing.Size(75, 21);
            this.close_panel.TabIndex = 2;
            this.close_panel.Text = "Zavřít";
            this.close_panel.UseVisualStyleBackColor = false;
            this.close_panel.Click += new System.EventHandler(this.close_panel_Click);
            // 
            // copy_button
            // 
            this.copy_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.copy_button.Location = new System.Drawing.Point(72, 80);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(220, 26);
            this.copy_button.TabIndex = 1;
            this.copy_button.Text = "kopírovat do schránky";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.kopírovat_Click);
            // 
            // code_label
            // 
            this.code_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.code_label.AutoSize = true;
            this.code_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.code_label.ForeColor = System.Drawing.Color.White;
            this.code_label.Location = new System.Drawing.Point(76, 42);
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(60, 24);
            this.code_label.TabIndex = 0;
            this.code_label.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.generateCode_button);
            this.panel2.Controls.Add(this.listOrder_button);
            this.panel2.Controls.Add(this.addOrder_button);
            this.panel2.Location = new System.Drawing.Point(391, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 254);
            this.panel2.TabIndex = 22;
            // 
            // generateCode_button
            // 
            this.generateCode_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generateCode_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generateCode_button.BackColor = System.Drawing.Color.White;
            this.generateCode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateCode_button.Location = new System.Drawing.Point(39, 157);
            this.generateCode_button.Name = "generateCode_button";
            this.generateCode_button.Size = new System.Drawing.Size(270, 40);
            this.generateCode_button.TabIndex = 21;
            this.generateCode_button.Text = "Generovat kód pro registraci";
            this.generateCode_button.UseVisualStyleBackColor = false;
            this.generateCode_button.Visible = false;
            this.generateCode_button.Click += new System.EventHandler(this.generateCode_button_Click);
            // 
            // logOut_button
            // 
            this.logOut_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logOut_button.BackColor = System.Drawing.Color.Red;
            this.logOut_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOut_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logOut_button.Location = new System.Drawing.Point(41, 584);
            this.logOut_button.Name = "logOut_button";
            this.logOut_button.Size = new System.Drawing.Size(166, 33);
            this.logOut_button.TabIndex = 20;
            this.logOut_button.Text = "Odhlásit se";
            this.logOut_button.UseVisualStyleBackColor = false;
            this.logOut_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 650);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.code_panel.ResumeLayout(false);
            this.code_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button addOrder_button;
        private System.Windows.Forms.Button listOrder_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOut_button;
        private System.Windows.Forms.Button generateCode_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel code_panel;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.Label code_label;
        private System.Windows.Forms.Button close_panel;
    }
}