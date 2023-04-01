namespace Omega
{
    partial class RozpocetList
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
            this.list_listBox = new System.Windows.Forms.ListBox();
            this.back_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.vytisknout_button = new System.Windows.Forms.Button();
            this.save_file_dialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_listBox
            // 
            this.list_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_listBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.list_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.list_listBox.FormattingEnabled = true;
            this.list_listBox.ItemHeight = 25;
            this.list_listBox.Location = new System.Drawing.Point(2, 6);
            this.list_listBox.Name = "list_listBox";
            this.list_listBox.Size = new System.Drawing.Size(777, 379);
            this.list_listBox.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_button.Location = new System.Drawing.Point(2, 406);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(143, 26);
            this.back_button.TabIndex = 21;
            this.back_button.Text = "Zpět";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // open_button
            // 
            this.open_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.open_button.Location = new System.Drawing.Point(636, 406);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(143, 26);
            this.open_button.TabIndex = 22;
            this.open_button.Text = "Otevřít";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.vytisknout_button);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.open_button);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.list_listBox);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 445);
            this.panel1.TabIndex = 23;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Red;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(233, 406);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(143, 26);
            this.delete_button.TabIndex = 23;
            this.delete_button.Text = "Smazat";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // vytisknout_button
            // 
            this.vytisknout_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vytisknout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vytisknout_button.Location = new System.Drawing.Point(398, 406);
            this.vytisknout_button.Name = "vytisknout_button";
            this.vytisknout_button.Size = new System.Drawing.Size(143, 26);
            this.vytisknout_button.TabIndex = 76;
            this.vytisknout_button.Text = "Vytisknout";
            this.vytisknout_button.UseVisualStyleBackColor = false;
            this.vytisknout_button.Click += new System.EventHandler(this.vytisknout_button_Click);
            // 
            // save_file_dialog
            // 
            this.save_file_dialog.DefaultExt = "pdf";
            this.save_file_dialog.FileName = "rozpocet";
            this.save_file_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.save_file_dialog_FileOk);
            // 
            // RozpocetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "RozpocetList";
            this.Text = "RozpocetList";
            this.Load += new System.EventHandler(this.RozpocetList_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_listBox;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button vytisknout_button;
        private System.Windows.Forms.SaveFileDialog save_file_dialog;
    }
}