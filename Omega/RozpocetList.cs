using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Omega
{
    public partial class RozpocetList : Form
    {
        public RozpocetList()
        {
            InitializeComponent();

            
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }


        private void RozpocetList_Load(object sender, EventArgs e)
        {
            foreach (Rozpocet r in Rozpocet.GetAllByNickname())
            {
                this.list_listBox.Items.Add(r);
            }
            this.list_listBox.MouseDoubleClick += new MouseEventHandler(list_listBox_MouseDoubleClick);
        }

        private void list_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.list_listBox.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)

            {
                this.Hide();
                int id = ((Rozpocet)this.list_listBox.Items[index]).Id;
                var RozpocetShow = new RozpocetShow(id);
                RozpocetShow.Show();


            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if (this.list_listBox.SelectedItem != null) {
                this.Hide();
                int id = ((Rozpocet)this.list_listBox.SelectedItem).Id;
                var RozpocetShow = new RozpocetShow(id);
                RozpocetShow.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.list_listBox.Items.Contains(this.list_listBox.SelectedItem))
                {
                    this.list_listBox.Items.Add(this.list_listBox.SelectedItem);
                    this.list_listBox.Items.Remove(this.list_listBox.SelectedItem);

                }
                else
                {
                    Rozpocet.delete(((Rozpocet)this.list_listBox.SelectedItem).Id);
                    this.list_listBox.Items.Remove(this.list_listBox.SelectedItem);


                }

            }
            catch
            {
                MessageBox.Show("Nebylo vybráno nic k odebrání");
            }

        }

        private void vytisknout_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.list_listBox.Items.Contains(this.list_listBox.SelectedItem))
                {
                    MessageBox.Show("Nebylo vybráno nic k exportu");
                }
                else
                {
                    this.save_file_dialog.ShowDialog();
                }
            }
            catch {
                MessageBox.Show("Nebylo vybráno nic k exportu");
            }
        }

        private void save_file_dialog_FileOk(object sender, CancelEventArgs e)
        {

            try
            {
                if (this.list_listBox.Items.Contains(this.list_listBox.SelectedItem))
                {
                    try
                    {
                        Document document = new Document(PageSize.A4, 50, 50, 25, 25);
                        Rozpocet selectedRozpocet = (Rozpocet)this.list_listBox.SelectedItem;
                        PdfWriter.GetInstance(document, new FileStream(this.save_file_dialog.FileName, FileMode.Create));

                        document.Open();


                        BaseFont font = BaseFont.CreateFont(@"C:\Windows\Fonts\dejavusans.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        iTextSharp.text.Font normalFont = new iTextSharp.text.Font(font, 12, iTextSharp.text.Font.NORMAL);
                        document.Add(new Paragraph(selectedRozpocet.Name_cust + " " + selectedRozpocet.Surname_cust, normalFont));
                        PdfPTable table = new PdfPTable(1);
                        Phrase phrase = new Phrase("Rozpočet", normalFont);
                        phrase.Font.Size = 20;
                        PdfPCell cell = new PdfPCell(phrase);
                        cell.Border = 0;
                        cell.Rowspan = 3;

                        cell.HorizontalAlignment = 1;
                        table.PaddingTop = 25;
                        table.AddCell(cell);

                        double total = 0;
                        foreach (Produkt p in selectedRozpocet.Products)
                        {
                            Paragraph paragraph = new Paragraph(p.Name + " | " + p.Count.ToString() + " " + p.Jednotka + " | " + p.Price.ToString() + ",- /" + p.Jednotka, normalFont);
                            paragraph.Font.Size = 8;
                            table.AddCell(paragraph);
                            total += (p.Count * p.Price);
                        }
                        document.Add(table);
                        
                        document.Add(new Paragraph("Celkem: " + total.ToString() + ",-",normalFont));
                        document.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Nelze uložit pdf");
                    }

                }
                else
                {
                    MessageBox.Show("Nebylo vybráno nic k exportu");


                }

            }
            catch
            {
                MessageBox.Show("Nebylo vybráno nic k exportu");
            }
            

            
        }
    }
}
