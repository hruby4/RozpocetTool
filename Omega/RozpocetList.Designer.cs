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
            this.SuspendLayout();
            // 
            // list_listBox
            // 
            this.list_listBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.list_listBox.FormattingEnabled = true;
            this.list_listBox.Location = new System.Drawing.Point(8, 12);
            this.list_listBox.Name = "list_listBox";
            this.list_listBox.Size = new System.Drawing.Size(777, 381);
            this.list_listBox.TabIndex = 0;
            this.list_listBox.SelectedIndexChanged += new System.EventHandler(this.list_listBox_SelectedIndexChanged);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_button.Location = new System.Drawing.Point(8, 412);
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
            this.open_button.Location = new System.Drawing.Point(642, 412);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(143, 26);
            this.open_button.TabIndex = 22;
            this.open_button.Text = "Otevřít";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // RozpocetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.list_listBox);
            this.Name = "RozpocetList";
            this.Text = "RozpocetList";
            this.Load += new System.EventHandler(this.RozpocetList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_listBox;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button open_button;
    }
}