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
            this.label5 = new System.Windows.Forms.Label();
            this.nickname_textbox = new System.Windows.Forms.TextBox();
            this.nickname_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.code_label = new System.Windows.Forms.Label();
            this.code_input = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.showPassword_button = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(373, 574);
            this.label5.Margin = new System.Windows.Forms.Padding(15);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.label5.Size = new System.Drawing.Size(370, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "Špatně vyplněná jedna z kolonek";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nickname_textbox
            // 
            this.nickname_textbox.Location = new System.Drawing.Point(449, 123);
            this.nickname_textbox.Name = "nickname_textbox";
            this.nickname_textbox.Size = new System.Drawing.Size(239, 20);
            this.nickname_textbox.TabIndex = 10;
            // 
            // nickname_label
            // 
            this.nickname_label.AutoSize = true;
            this.nickname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nickname_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nickname_label.Location = new System.Drawing.Point(449, 98);
            this.nickname_label.Name = "nickname_label";
            this.nickname_label.Size = new System.Drawing.Size(76, 16);
            this.nickname_label.TabIndex = 11;
            this.nickname_label.Text = "Nickname";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(449, 202);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(239, 20);
            this.password_textbox.TabIndex = 12;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.password_label.Location = new System.Drawing.Point(449, 177);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(48, 16);
            this.password_label.TabIndex = 13;
            this.password_label.Text = "Heslo";
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_button.Location = new System.Drawing.Point(499, 355);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(143, 26);
            this.register_button.TabIndex = 14;
            this.register_button.Text = "Potvrdit";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // code_label
            // 
            this.code_label.AutoSize = true;
            this.code_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.code_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.code_label.Location = new System.Drawing.Point(447, 251);
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(34, 16);
            this.code_label.TabIndex = 18;
            this.code_label.Text = "Kód";
            // 
            // code_input
            // 
            this.code_input.Location = new System.Drawing.Point(447, 276);
            this.code_input.MaxLength = 20;
            this.code_input.Name = "code_input";
            this.code_input.Size = new System.Drawing.Size(239, 20);
            this.code_input.TabIndex = 17;
            // 
            // back_button
            // 
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
            this.showPassword_button.AutoSize = true;
            this.showPassword_button.Location = new System.Drawing.Point(449, 228);
            this.showPassword_button.Name = "showPassword_button";
            this.showPassword_button.Size = new System.Drawing.Size(92, 17);
            this.showPassword_button.TabIndex = 20;
            this.showPassword_button.Text = "Zobrazit heslo";
            this.showPassword_button.UseVisualStyleBackColor = true;
            this.showPassword_button.CheckedChanged += new System.EventHandler(this.showPassword_button_CheckedChanged);
            // 
            // Registrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1130, 650);
            this.Controls.Add(this.showPassword_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.code_label);
            this.Controls.Add(this.code_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.nickname_label);
            this.Controls.Add(this.nickname_textbox);
            this.Name = "Registrace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nickname_textbox;
        private System.Windows.Forms.Label nickname_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label code_label;
        private System.Windows.Forms.TextBox code_input;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.CheckBox showPassword_button;
    }
}