using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileProcess
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            string row = string.Empty;
            StreamReader fileCategory = File.OpenText("E:\\StokApp\\category.txt");

            row = fileCategory.ReadLine();
            //her kategoriden bir tane eklemek için
            while (row != null)
            {
                comboBox1.Items.Add(row);
                row = fileCategory.ReadLine();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Ürün eklemek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (File.Exists("E:\\StokApp\\product.txt"))
                {
                    StreamWriter dosyayaz = File.AppendText("E:\\StokApp\\product.txt");
                    dosyayaz.WriteLine(comboBox1.Text + "#" + txtProductName.Text + "#" + txtStock.Text + "#" + txtPrice.Text + "#");
                    dosyayaz.Close();
                    //this.Dispose();
                }
            }
        }

        
    }
}
