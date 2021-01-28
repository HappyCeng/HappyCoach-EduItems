using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileProcess
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("" + textBox1.Text + " eklemek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (File.Exists("E:\\StokApp\\category.txt"))
                {
                    StreamWriter dosyayaz = File.AppendText("E:\\StokApp\\category.txt");
                    dosyayaz.WriteLine(textBox1.Text);
                    dosyayaz.Close();
                    //this.Dispose();
                }
            }
            
        }
    }
}
