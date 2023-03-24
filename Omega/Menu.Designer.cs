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
            this.generateCode_button = new System.Windows.Forms.Button();
            this.logOut_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addOrder_button
            // 
            this.addOrder_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addOrder_button.Location = new System.Drawing.Point(439, 162);
            this.addOrder_button.MaximumSize = new System.Drawing.Size(300, 40);
            this.addOrder_button.MinimumSize = new System.Drawing.Size(80, 20);
            this.addOrder_button.Name = "addOrder_button";
            this.addOrder_button.Size = new System.Drawing.Size(300, 40);
            this.addOrder_button.TabIndex = 0;
            this.addOrder_button.Text = "Vytvořit rozpočet";
            this.addOrder_button.UseVisualStyleBackColor = true;
            this.addOrder_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOrder_button
            // 
            this.listOrder_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listOrder_button.Location = new System.Drawing.Point(439, 227);
            this.listOrder_button.MaximumSize = new System.Drawing.Size(300, 40);
            this.listOrder_button.MinimumSize = new System.Drawing.Size(80, 20);
            this.listOrder_button.Name = "listOrder_button";
            this.listOrder_button.Size = new System.Drawing.Size(300, 40);
            this.listOrder_button.TabIndex = 1;
            this.listOrder_button.Text = "Moje rozpočty";
            this.listOrder_button.UseVisualStyleBackColor = true;
            this.listOrder_button.Click += new System.EventHandler(this.listOrder_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.generateCode_button);
            this.panel1.Controls.Add(this.logOut_button);
            this.panel1.Controls.Add(this.listOrder_button);
            this.panel1.Controls.Add(this.addOrder_button);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 638);
            this.panel1.TabIndex = 2;
            // 
            // generateCode_button
            // 
            this.generateCode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateCode_button.Location = new System.Drawing.Point(978, 27);
            this.generateCode_button.Name = "generateCode_button";
            this.generateCode_button.Size = new System.Drawing.Size(109, 21);
            this.generateCode_button.TabIndex = 21;
            this.generateCode_button.Text = "Generovat kód";
            this.generateCode_button.UseVisualStyleBackColor = true;
            this.generateCode_button.Visible = false;
            this.generateCode_button.Click += new System.EventHandler(this.generateCode_button_Click);
            // 
            // logOut_button
            // 
            this.logOut_button.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button addOrder_button;
        private System.Windows.Forms.Button listOrder_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOut_button;
        private System.Windows.Forms.Button generateCode_button;
    }
}