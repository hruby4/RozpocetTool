using System;

namespace Omega
{
    partial class Login
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Label();
            this.nickname_textbox = new System.Windows.Forms.TextBox();
            this.nickname_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showPassword_button = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Header.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(203)))));
            this.Header.Location = new System.Drawing.Point(325, 13);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(135, 96);
            this.Header.TabIndex = 0;
            this.Header.Text = "Vitejte";
            // 
            // nickname_textbox
            // 
            this.nickname_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nickname_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(179)))));
            this.nickname_textbox.Location = new System.Drawing.Point(275, 94);
            this.nickname_textbox.Name = "nickname_textbox";
            this.nickname_textbox.Size = new System.Drawing.Size(239, 20);
            this.nickname_textbox.TabIndex = 1;
            // 
            // nickname_label
            // 
            this.nickname_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nickname_label.AutoSize = true;
            this.nickname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nickname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(203)))));
            this.nickname_label.Location = new System.Drawing.Point(275, 69);
            this.nickname_label.Name = "nickname_label";
            this.nickname_label.Size = new System.Drawing.Size(76, 16);
            this.nickname_label.TabIndex = 2;
            this.nickname_label.Text = "Nickname";
            // 
            // password_textbox
            // 
            this.password_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.password_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(203)))));
            this.password_textbox.Location = new System.Drawing.Point(275, 162);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(239, 20);
            this.password_textbox.TabIndex = 3;
            // 
            // password_label
            // 
            this.password_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(203)))));
            this.password_label.Location = new System.Drawing.Point(275, 137);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(48, 16);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Heslo";
            // 
            // login_button
            // 
            this.login_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_button.AutoSize = true;
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(222)))));
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_button.ForeColor = System.Drawing.Color.Black;
            this.login_button.Location = new System.Drawing.Point(319, 295);
            this.login_button.MaximumSize = new System.Drawing.Size(150, 50);
            this.login_button.MinimumSize = new System.Drawing.Size(80, 25);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(150, 50);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Přihlásit se";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // register_button
            // 
            this.register_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(138)))), ((int)(((byte)(196)))));
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_button.ForeColor = System.Drawing.Color.Black;
            this.register_button.Location = new System.Drawing.Point(152, 371);
            this.register_button.Name = "register_button";
            this.register_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.register_button.Size = new System.Drawing.Size(481, 39);
            this.register_button.TabIndex = 6;
            this.register_button.Text = "Nejsem zaregistrovan, ale mam kod k zaregistrování";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.showPassword_button);
            this.panel1.Controls.Add(this.register_button);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.password_label);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.nickname_label);
            this.panel1.Controls.Add(this.nickname_textbox);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Location = new System.Drawing.Point(113, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 473);
            this.panel1.TabIndex = 9;
            // 
            // showPassword_button
            // 
            this.showPassword_button.AutoSize = true;
            this.showPassword_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(203)))));
            this.showPassword_button.Location = new System.Drawing.Point(276, 193);
            this.showPassword_button.Name = "showPassword_button";
            this.showPassword_button.Size = new System.Drawing.Size(92, 17);
            this.showPassword_button.TabIndex = 9;
            this.showPassword_button.Text = "Zobrazit heslo";
            this.showPassword_button.UseVisualStyleBackColor = true;
            this.showPassword_button.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1012, 644);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox nickname_textbox;
        private System.Windows.Forms.Label nickname_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox showPassword_button;
    }
}

