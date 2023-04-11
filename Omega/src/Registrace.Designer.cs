using System;

namespace Omega
{
    partial class Registrace
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
            this.nickname_textbox = new System.Windows.Forms.TextBox();
            this.nickname_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.code_label = new System.Windows.Forms.Label();
            this.code_input = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.showPassword_button = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nickname_textbox
            // 
            this.nickname_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nickname_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nickname_textbox.Location = new System.Drawing.Point(70, 107);
            this.nickname_textbox.Name = "nickname_textbox";
            this.nickname_textbox.Size = new System.Drawing.Size(405, 24);
            this.nickname_textbox.TabIndex = 10;
            // 
            // nickname_label
            // 
            this.nickname_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nickname_label.AutoSize = true;
            this.nickname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nickname_label.ForeColor = System.Drawing.Color.Black;
            this.nickname_label.Location = new System.Drawing.Point(70, 82);
            this.nickname_label.Name = "nickname_label";
            this.nickname_label.Size = new System.Drawing.Size(76, 16);
            this.nickname_label.TabIndex = 11;
            this.nickname_label.Text = "Nickname";
            // 
            // password_textbox
            // 
            this.password_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_textbox.Location = new System.Drawing.Point(70, 186);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(405, 24);
            this.password_textbox.TabIndex = 12;
            // 
            // password_label
            // 
            this.password_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_label.ForeColor = System.Drawing.Color.Black;
            this.password_label.Location = new System.Drawing.Point(70, 161);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(48, 16);
            this.password_label.TabIndex = 13;
            this.password_label.Text = "Heslo";
            // 
            // register_button
            // 
            this.register_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_button.Location = new System.Drawing.Point(204, 338);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(143, 26);
            this.register_button.TabIndex = 14;
            this.register_button.Text = "Potvrdit";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // code_label
            // 
            this.code_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.code_label.AutoSize = true;
            this.code_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.code_label.ForeColor = System.Drawing.Color.Black;
            this.code_label.Location = new System.Drawing.Point(68, 250);
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(34, 16);
            this.code_label.TabIndex = 18;
            this.code_label.Text = "Kód";
            // 
            // code_input
            // 
            this.code_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.code_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.code_input.Location = new System.Drawing.Point(68, 275);
            this.code_input.MaxLength = 20;
            this.code_input.Name = "code_input";
            this.code_input.Size = new System.Drawing.Size(407, 24);
            this.code_input.TabIndex = 17;
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_button.Location = new System.Drawing.Point(22, 601);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(143, 26);
            this.back_button.TabIndex = 19;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // showPassword_button
            // 
            this.showPassword_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPassword_button.AutoSize = true;
            this.showPassword_button.Location = new System.Drawing.Point(70, 213);
            this.showPassword_button.Name = "showPassword_button";
            this.showPassword_button.Size = new System.Drawing.Size(92, 17);
            this.showPassword_button.TabIndex = 20;
            this.showPassword_button.Text = "Zobrazit heslo";
            this.showPassword_button.UseVisualStyleBackColor = true;
            this.showPassword_button.CheckedChanged += new System.EventHandler(this.showPassword_button_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(143, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 55);
            this.label1.TabIndex = 21;
            this.label1.Text = "Registrace";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.showPassword_button);
            this.panel1.Controls.Add(this.code_label);
            this.panel1.Controls.Add(this.code_input);
            this.panel1.Controls.Add(this.register_button);
            this.panel1.Controls.Add(this.password_label);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.nickname_label);
            this.panel1.Controls.Add(this.nickname_textbox);
            this.panel1.Location = new System.Drawing.Point(295, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 399);
            this.panel1.TabIndex = 22;
            // 
            // Registrace
            // 
            this.AcceptButton = this.register_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.back_button;
            this.ClientSize = new System.Drawing.Size(1130, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_button);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(1146, 689);
            this.Name = "Registrace";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.TextBox nickname_textbox;
        private System.Windows.Forms.Label nickname_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label code_label;
        private System.Windows.Forms.TextBox code_input;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.CheckBox showPassword_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}